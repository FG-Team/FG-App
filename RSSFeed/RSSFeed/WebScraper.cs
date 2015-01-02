using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Functional;

namespace RSSFeed_Test
{
    class WebScraper
    {
        public static string DownloadWebpage(string url)
        {
            try
            {
                var reader = new System.IO.StreamReader(WebRequest.Create(url).GetResponse().GetResponseStream());
                return reader.ReadToEnd();
            }
            catch (WebException)
            {
                System.Windows.Forms.MessageBox.Show("URL " + url + " does not exist", "System.Net.WebException");
                return null;
            }
        }

        public static void SaveToDisk(string url, string path)
        {
            var client = new WebClient();
            try
            {
                client.DownloadFile(url, path);
            }
            catch (WebException)
            {
                System.Windows.Forms.MessageBox.Show("Cannot download file " + url, "System.Net.WebException");
            }
        }

        public static long Size(string url)
        {
            return WebRequest.Create(url).GetResponse().GetResponseStream().Length;
        }
    }
}
