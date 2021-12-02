using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;

namespace Anime_Downloader
{
    class LinkResolver
    {
        public string resolver(String Url)
        {
            string pattern = @"sources:\[\{file: '(.*)',label:";

            HtmlWeb web1 = new HtmlWeb();
            web1.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HtmlDocument document1 = web1.Load(Url);

            HtmlNode embedURL = document1.DocumentNode.SelectSingleNode("//*[@id='main_bg']/div[5]/div/div[1]/div[1]/div[1]/iframe");
            string link = embedURL.Attributes["src"].Value;
            
            HtmlWeb web2 = new HtmlWeb();
            web2.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HtmlDocument document2 = web2.Load($"https:{link}");

            HtmlNode embdedUrl = document2.DocumentNode.SelectSingleNode("//*[@id='list-server-more']/ul/li[2]");
            string embdedLink = embdedUrl.Attributes["data-video"].Value;

            HtmlWeb web3 = new HtmlWeb();
            web2.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            HtmlDocument document3 = web3.Load($"{embdedLink}");

            HtmlNode jsScriptNode = document3.DocumentNode.SelectSingleNode("/html/body/div/div/script");
            string jsScript = jsScriptNode.InnerText;

            Match m = Regex.Match(jsScript, pattern);
            return m.Groups[1].ToString();
        }
    }
}
