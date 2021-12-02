
namespace Anime_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paypalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_SearchUI = new System.Windows.Forms.Panel();
            this.ListView_SearchResults = new System.Windows.Forms.ListView();
            this.Button_Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Textbox_Query = new System.Windows.Forms.TextBox();
            this.Panel_Episodes = new System.Windows.Forms.Panel();
            this.Button_GoBack = new System.Windows.Forms.Button();
            this.ListView_Episodes = new System.Windows.Forms.ListView();
            this.label_Anime_Title = new System.Windows.Forms.Label();
            this.PictureBox_Anime_Cover = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.Panel_SearchUI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel_Episodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Anime_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.youtubeChannelToolStripMenuItem,
            this.telegramChannelToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // youtubeChannelToolStripMenuItem
            // 
            this.youtubeChannelToolStripMenuItem.Name = "youtubeChannelToolStripMenuItem";
            this.youtubeChannelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.youtubeChannelToolStripMenuItem.Text = "Youtube Channel";
            this.youtubeChannelToolStripMenuItem.Click += new System.EventHandler(this.youtubeChannelToolStripMenuItem_Click);
            // 
            // telegramChannelToolStripMenuItem
            // 
            this.telegramChannelToolStripMenuItem.Name = "telegramChannelToolStripMenuItem";
            this.telegramChannelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.telegramChannelToolStripMenuItem.Text = "Telegram Channel";
            this.telegramChannelToolStripMenuItem.Click += new System.EventHandler(this.telegramChannelToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paypalToolStripMenuItem,
            this.cryptoToolStripMenuItem});
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.donateToolStripMenuItem.Text = "Donate";
            // 
            // paypalToolStripMenuItem
            // 
            this.paypalToolStripMenuItem.Name = "paypalToolStripMenuItem";
            this.paypalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paypalToolStripMenuItem.Text = "Paypal";
            this.paypalToolStripMenuItem.Click += new System.EventHandler(this.paypalToolStripMenuItem_Click);
            // 
            // cryptoToolStripMenuItem
            // 
            this.cryptoToolStripMenuItem.Name = "cryptoToolStripMenuItem";
            this.cryptoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cryptoToolStripMenuItem.Text = "Crypto";
            this.cryptoToolStripMenuItem.Click += new System.EventHandler(this.cryptoToolStripMenuItem_Click);
            // 
            // Panel_SearchUI
            // 
            this.Panel_SearchUI.Controls.Add(this.ListView_SearchResults);
            this.Panel_SearchUI.Controls.Add(this.Button_Search);
            this.Panel_SearchUI.Controls.Add(this.groupBox1);
            this.Panel_SearchUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_SearchUI.Location = new System.Drawing.Point(0, 28);
            this.Panel_SearchUI.Name = "Panel_SearchUI";
            this.Panel_SearchUI.Size = new System.Drawing.Size(998, 642);
            this.Panel_SearchUI.TabIndex = 1;
            // 
            // ListView_SearchResults
            // 
            this.ListView_SearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_SearchResults.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_SearchResults.HideSelection = false;
            this.ListView_SearchResults.Location = new System.Drawing.Point(12, 106);
            this.ListView_SearchResults.Name = "ListView_SearchResults";
            this.ListView_SearchResults.Size = new System.Drawing.Size(974, 524);
            this.ListView_SearchResults.TabIndex = 2;
            this.ListView_SearchResults.UseCompatibleStateImageBehavior = false;
            this.ListView_SearchResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_SearchResults_MouseClick);
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.Location = new System.Drawing.Point(828, 16);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(158, 73);
            this.Button_Search.TabIndex = 1;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Textbox_Query);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Anime";
            // 
            // Textbox_Query
            // 
            this.Textbox_Query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_Query.Location = new System.Drawing.Point(6, 36);
            this.Textbox_Query.Name = "Textbox_Query";
            this.Textbox_Query.Size = new System.Drawing.Size(767, 30);
            this.Textbox_Query.TabIndex = 1;
            // 
            // Panel_Episodes
            // 
            this.Panel_Episodes.Controls.Add(this.Button_GoBack);
            this.Panel_Episodes.Controls.Add(this.ListView_Episodes);
            this.Panel_Episodes.Controls.Add(this.label_Anime_Title);
            this.Panel_Episodes.Controls.Add(this.PictureBox_Anime_Cover);
            this.Panel_Episodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Episodes.Location = new System.Drawing.Point(0, 28);
            this.Panel_Episodes.Name = "Panel_Episodes";
            this.Panel_Episodes.Size = new System.Drawing.Size(998, 642);
            this.Panel_Episodes.TabIndex = 3;
            this.Panel_Episodes.Visible = false;
            // 
            // Button_GoBack
            // 
            this.Button_GoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GoBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GoBack.Location = new System.Drawing.Point(845, 16);
            this.Button_GoBack.Name = "Button_GoBack";
            this.Button_GoBack.Size = new System.Drawing.Size(141, 56);
            this.Button_GoBack.TabIndex = 3;
            this.Button_GoBack.Text = "Go Back";
            this.Button_GoBack.UseVisualStyleBackColor = true;
            this.Button_GoBack.Click += new System.EventHandler(this.Button_GoBack_Click);
            // 
            // ListView_Episodes
            // 
            this.ListView_Episodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_Episodes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_Episodes.HideSelection = false;
            this.ListView_Episodes.Location = new System.Drawing.Point(12, 287);
            this.ListView_Episodes.Name = "ListView_Episodes";
            this.ListView_Episodes.Size = new System.Drawing.Size(974, 343);
            this.ListView_Episodes.TabIndex = 2;
            this.ListView_Episodes.UseCompatibleStateImageBehavior = false;
            this.ListView_Episodes.View = System.Windows.Forms.View.Tile;
            this.ListView_Episodes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Episodes_MouseClick);
            // 
            // label_Anime_Title
            // 
            this.label_Anime_Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Anime_Title.Location = new System.Drawing.Point(257, 16);
            this.label_Anime_Title.Name = "label_Anime_Title";
            this.label_Anime_Title.Size = new System.Drawing.Size(553, 170);
            this.label_Anime_Title.TabIndex = 1;
            // 
            // PictureBox_Anime_Cover
            // 
            this.PictureBox_Anime_Cover.Location = new System.Drawing.Point(12, 16);
            this.PictureBox_Anime_Cover.Name = "PictureBox_Anime_Cover";
            this.PictureBox_Anime_Cover.Size = new System.Drawing.Size(226, 246);
            this.PictureBox_Anime_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Anime_Cover.TabIndex = 0;
            this.PictureBox_Anime_Cover.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 670);
            this.Controls.Add(this.Panel_SearchUI);
            this.Controls.Add(this.Panel_Episodes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Anime Downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel_SearchUI.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel_Episodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Anime_Cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paypalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cryptoToolStripMenuItem;
        private System.Windows.Forms.Panel Panel_SearchUI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Textbox_Query;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.ListView ListView_SearchResults;
        private System.Windows.Forms.Panel Panel_Episodes;
        private System.Windows.Forms.PictureBox PictureBox_Anime_Cover;
        private System.Windows.Forms.Label label_Anime_Title;
        private System.Windows.Forms.ListView ListView_Episodes;
        private System.Windows.Forms.Button Button_GoBack;
    }
}

