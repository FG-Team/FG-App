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
	//[Activity(Label = "BasicTable", MainLauncher = true, Icon = "@drawable/icon")]
	public class Aktuelles : Fragment
	{
		/*
        string[] items;

		protected override void OnStart()
		{
			base.OnStart();
			items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
		}

		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var t = items[position];
            Android.Widget.Toast.MakeText((getActivity())this, t, Android.Widget.ToastLength.Short).Show();
			Console.WriteLine("Clicked on " + t);
		}*/

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

