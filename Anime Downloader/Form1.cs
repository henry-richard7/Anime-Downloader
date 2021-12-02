using System;
using System.Drawing;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Anime_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public HtmlNodeCollection searchDramaImage;
        public HtmlNodeCollection searchDramaUrls;
        public HtmlNodeCollection dramaEpisodeUrl;

        public string base_url = "https://gogoplay1.com";

        private void searchDrama()
        {
            try
            {
                ListView_SearchResults.Items.Clear();
                ImageList images = new ImageList();
                images.ImageSize = new Size(245, 250);
                images.ColorDepth = ColorDepth.Depth32Bit;

                HtmlWeb searchDramaWeb = new HtmlWeb();
                searchDramaWeb.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
                HtmlAgilityPack.HtmlDocument searchDramaResults = searchDramaWeb.Load($"{base_url}/search.html?keyword={Textbox_Query.Text}");

                searchDramaImage = searchDramaResults.DocumentNode.SelectNodes("//*[@id='main_bg']/div[5]/div/div[3]/div[1]/div/div/ul/li[*]/a/div[1]/div[1]/img");
                searchDramaUrls = searchDramaResults.DocumentNode.SelectNodes("//*[@id='main_bg']/div[5]/div/div[3]/div[1]/div/div/ul/li[*]/a");

                if (searchDramaUrls == null)
                    MessageBox.Show($"No results found for {Textbox_Query.Text}!", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    for (int i = 0; i < searchDramaUrls.Count; i++)
                    {
                        try
                        {
                            WebClient w = new WebClient();
                            
                            byte[] imageBytes = w.DownloadData(searchDramaImage[i].Attributes["src"].Value);
                            MemoryStream memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length);
                            memoryStream.Write(imageBytes, 0, imageBytes.Length);
                            Image imgs = Image.FromStream(memoryStream, true);
                            images.Images.Add(imgs);
                        }
                        catch
                        {
                            images.Images.Add("No Image",Properties.Resources.No_Image);
                        }
                        

                        ListView_SearchResults.Items.Add(searchDramaImage[i].Attributes["alt"].Value, i);

                    }
                    ListView_SearchResults.LargeImageList = images;
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Check if you have active internet connection or try with VPN!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(searchDrama);
            thread.Start();
            thread.IsBackground = true;
        }

        private void ListView_SearchResults_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string selectedDramaUrl = $"{base_url}{searchDramaUrls[ListView_SearchResults.FocusedItem.Index].Attributes["href"].Value}";
                label_Anime_Title.Text = searchDramaImage[ListView_SearchResults.FocusedItem.Index].Attributes["alt"].Value;

                try
                {
                    PictureBox_Anime_Cover.Load(searchDramaImage[ListView_SearchResults.FocusedItem.Index].Attributes["src"].Value);
                }
                catch
                {
                    PictureBox_Anime_Cover.Image = Properties.Resources.No_Image;
                }

                Panel_SearchUI.Visible = false;
                Panel_Episodes.Visible = true;

                HtmlWeb web = new HtmlWeb();
                web.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
                HtmlAgilityPack.HtmlDocument document = web.Load(selectedDramaUrl);

                dramaEpisodeUrl = document.DocumentNode.SelectNodes("//*[@id='main_bg']/div[5]/div/div[1]/ul/li[*]/a");
                var dramaType = document.DocumentNode.SelectNodes("//*[@id='main_bg']/div[5]/div/div[1]/ul/li[*]/a/div[1]/div[3]/span");
                var dramaTitle = document.DocumentNode.SelectNodes("//*[@id='main_bg']/div[5]/div/div[1]/ul/li[*]/a/div[2]/text()");

                for (int i = dramaTitle.Count - 1; i >= 0; i--)
                {
                    ListView_Episodes.Items.Add(dramaTitle[i].InnerText.Trim() +" - "+ dramaType[i].InnerText);
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Check if you have active internet connection or try with VPN!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Button_GoBack_Click(object sender, EventArgs e)
        {
            Panel_SearchUI.Visible = true;
            Panel_Episodes.Visible = false;
            dramaEpisodeUrl.Clear();
            ListView_Episodes.Items.Clear();
        }

        private void ListView_Episodes_MouseClick(object sender, MouseEventArgs e)
        {
            int retifier = dramaEpisodeUrl.Count - 1;
            string selectedEpisodeUrl = $"{base_url}{dramaEpisodeUrl[retifier - ListView_Episodes.FocusedItem.Index].Attributes["href"].Value}";

            LinkResolver linkResolver = new LinkResolver();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            string augs = "--referer https://gogoplay1.com/";

            startInfo.FileName = Environment.CurrentDirectory + @"\\yt-dlp.exe";
            startInfo.Arguments = augs + " " + linkResolver.resolver(selectedEpisodeUrl) + " " + "--external-downloader aria2c --downloader-args aria2c: - x 16 - k 1M" + $" -o {"\""}/Downloads/{ListView_Episodes.FocusedItem.Text}.%(ext)s{"\""}";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://henry-richard-tools.ml");
        }

        private void youtubeChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCVGasc5jr45eZUpZNHvbtWQ");
        }

        private void telegramChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/hr_tools");
        }

        private void paypalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/paypalme/henryrics");
        }

        private void cryptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://henry-richard7.github.io/Donation-Page/");
        }
    }

}

