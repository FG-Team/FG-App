using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koopakiller.NewsFeed;
using System.Xml;
using System.Net;
using System.IO;
using Android.App;

namespace FG_App
{
	public class RSSReader
	{
		string Url { get; set; }
        Activity CurrentActivity { get; set; }

		private Func<string, bool> IsNullOrWhiteSpaceOrEmpty = s => 
			String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s);

        public readonly static string FeedFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

		public string MakeFileName()
		{
			return string.Format (
				"{0}.rss", 
                String.Concat(
                    new Uri (this.Url)
    					.GetLeftPart (UriPartial.Authority)
    					.SkipWhile (c => c != '.')
    					.Skip (1)
                        .TakeWhile (c => c != '.')
                ));
		}

        public void DownloadFeed(string fileName)
        {
            /* try{
                using (var client = new WebClient ()) {
                    // client.DownloadProgressChanged  += new DownloadProgressChangedEventHandler(null);
                    // client.DownloadFileCompleted    += new AsyncCompletedEventHandler(null);
                    client.DownloadFileAsync(new Uri(Url), Path.Combine(FeedFolder, fileName));
                }
            }
            catch (UriFormatException) {
                new AlertDialog.Builder(CurrentActivity).SetMessage ("URL'is forma mala est ").SetTitle("System.UriFormatException").Show();
            } */
            var client = new WebClient();
            client.DownloadStringCompleted += (s, e) => {
                var text = e.Result; // get the downloaded text
                File.WriteAllText (Path.Combine (FeedFolder, fileName), text); // writes to local storage   
            };
            var url = new Uri(this.Url);
            client.Encoding = Encoding.UTF8;
            client.DownloadStringAsync(url);
        }

		public void DownloadFeed()
		{
            DownloadFeed("downloaded_feed.rss");		    
		}

        public RSSReader (string url, Activity activity)
		{
			Url = url;
            CurrentActivity = activity;
		}
	}
}

