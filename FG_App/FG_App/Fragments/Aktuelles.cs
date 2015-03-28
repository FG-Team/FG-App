using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace FG_App
{
	/// <summary>
	/// Initialisiert eine neue Instanz der Aktuelles Klasse.
	/// </summary>
	public class Aktuelles : Fragment
	{
		/*String[] listData = { "Post 1", "Post 2", "Post 3", "Post 4", "Post 5", "Post 6" };

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			setContentView(R.layout.activity_postlist);
            
			ListView listView = (ListView)this.findViewById(R.id.postListView);
			ArrayAdapter<String> itemAdapter = new ArrayAdapter<String>(this, R.layout.postitem, listData);
			listView.setAdapter(itemAdapter);
		}
        */
		/// <summary>
		/// Übersteuerung für OnCreateView.
		/// </summary>
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View aktuelles = inflater.Inflate(Resource.Layout.Aktuelles, container, false);
			return aktuelles;
		}
	}
}

