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
using Android.Widget;

namespace FG_App
{
	/// <summary>
	/// Initialisiert eine neue Instanz der RSSReader Klasse.
	/// </summary>
	public class RSSReader
	{
		string Url { get; set; }

		Activity CurrentActivity { get; set; }

		private Func<string, bool> IsNullOrWhiteSpaceOrEmpty = s => 
			String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s);

		/// <summary>
		/// Festlegung des FeedFolders.
		/// </summary>
		public readonly static string FeedFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

		/// <summary>
		/// Erstellung eines Dateinamens.
		/// </summary>
		public string MakeFileName()
		{
			return string.Format(
				"{0}.rss", 
				String.Concat(
					new Uri(this.Url)
    					.GetLeftPart(UriPartial.Authority)
    					.SkipWhile(c => c != '.')
    					.Skip(1)
                        .TakeWhile(c => c != '.')
				));
		}

		/// <summary>
		/// Herunterladen des Feeds.
		/// </summary>
		/// <param name="fileName">Der Dateiname.</param>
		/// <param name="act">Die Activity.</param>
		public List<string> DownloadFeed(string fileName, MainActivity act)
		{
			List<string> articels = null;

			try
			{
				var client = new WebClient();
				var url = new Uri(this.Url);
				client.Encoding = Encoding.UTF8;
				
				//Write feed to stream
				Stream s = new MemoryStream(Encoding.UTF8.GetBytes(client.DownloadString(url)));

				//Load feed
				var rss = new RSSFeed();
				rss.Load(s);

				//Get the articles
				articels = rss.Articles.Select(feed => ((RSSFeedArticle)feed).Title).ToList();

				client.Dispose();
			}
			catch
			{
				Android.Widget.Toast.MakeText(act, "RSS-Feed konnte nicht geladen werden.", Android.Widget.ToastLength.Long).Show();
			}

			return articels;
		}

		/*public void DownloadFeed()
		{
			DownloadFeed("downloaded_feed.rss");		    
		}*/

		/// <summary>
		/// Herunterladen des Feeds.
		/// </summary>
		/// <param name="url">Die URL.</param>
		/// <param name="activity">Die Activity.</param>
		public RSSReader(string url, Activity activity)
		{
			Url = url;
			CurrentActivity = activity;
		}
	}
}

