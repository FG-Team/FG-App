using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Koopakiller.NewsFeed;
using System.Xml;
using System.Net;
using System.IO;

namespace RSSFeed_Test
{
    public partial class MainWindow : Form
    {
        private static Func<string, string> MakeFileName = (string url) => 
            String.Concat(new Uri(url).GetLeftPart(UriPartial.Authority).SkipWhile(c => c != '.').Skip(1).TakeWhile(c => c != '.')) + ".feed";
      
        private static Func<string, bool> IsNullOrWhiteSpaceOrEmpty = (string s) => 
            String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s);

        private static string tempFolder    = System.IO.Path.GetTempPath();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetButton.Enabled = false;
                using (var client = new WebClient())
                {
                    client.DownloadProgressChanged  += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted    += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadFileAsync(new Uri(InputTextBox.Text), tempFolder + MakeFileName(InputTextBox.Text));
                }
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Malformed URL", "System.UriFormatException");
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                DownloadProgressBar.Maximum = (int)e.TotalBytesToReceive / 100;
                DownloadProgressBar.Value   = (int)e.BytesReceived / 100;
            }
            catch (ArgumentException) { return; }
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            GetButton.Enabled           = true;
            var feed                    = new RSSFeed();
            feed.Load(tempFolder + MakeFileName(InputTextBox.Text));

            AuthorTextLabel.Text        = feed.Author;
            CountTextLabel.Text         = feed.Articles.Count.ToString();
            DescriptionTextLabel.Text   = feed.Description;
            PublishedTextLabel.Text     = feed.Published.ToString();
            URLTextLabel.Text           = feed.ArticleUrl;

            var newestCount = 3;
            if (feed.Articles.Count >= newestCount)
            {
                NewestLabel.Text = String.Empty;
                for (var i = 0; i < newestCount; i++)
                    NewestLabel.Text += (i + 1).ToString() + ". " + feed.Articles[i].ToString() + "\n";
            }
        }
    }
}