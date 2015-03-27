using System;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Support.V4.Widget;
using Android.Support.V4.App;
using Koopakiller.NewsFeed;
using System.IO;
using Java.Security;

namespace FG_App
{
	[Activity(Label = "FG-App", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/CustomActionBarTheme")]
	public class MainActivity : Activity
	{
		DrawerLayout mDrawerLayout;
		List<string> mLeftItems = new List<string>();
		ArrayAdapter mLeftAdapter;
		ListView mLeftDrawer;
		ActionBarDrawerToggle mDrawerToggle;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			//Build the view
			SetContentView(Resource.Layout.Main);

			mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.myDrawer);
			mLeftDrawer = FindViewById<ListView>(Resource.Id.leftListView);

			mLeftItems.Add("Schule");
			mLeftItems.Add("Aktuelles");
			mLeftItems.Add("SV");
			mLeftItems.Add("Termine");
			mLeftItems.Add("Klausuren");
			mLeftItems.Add("Kontakt");
			mLeftItems.Add("Einstellungen");

			mDrawerToggle =	new MyActionBarDrawerToggle(this, mDrawerLayout, Resource.Drawable.IcNavigationDrawer, Resource.String.open_drawer, Resource.String.close_drawer);
			mLeftAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, mLeftItems);
			mLeftDrawer.Adapter = mLeftAdapter;

			mLeftDrawer.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) =>
			{
				switch (mLeftDrawer.CheckedItemPosition)
				{
				//Schule
					case 0:
						Android.App.FragmentTransaction schule = FragmentManager.BeginTransaction();
						schule.Replace(Resource.Id.container, new Schule());
						schule.AddToBackStack(null);
						schule.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Schule";
						break;
				//Aktuelles
					case 1:
						Android.App.FragmentTransaction aktuelles = FragmentManager.BeginTransaction();
						aktuelles.Replace(Resource.Id.container, new Aktuelles());
						aktuelles.AddToBackStack(null);
						aktuelles.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Aktuelles";
						break;
				//SV
					case 2:
						Android.App.FragmentTransaction sv = FragmentManager.BeginTransaction();
						sv.Replace(Resource.Id.container, new SV());
						sv.AddToBackStack(null);
						sv.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "SV";
						break;
				//Termine
					case 3:
						Android.App.FragmentTransaction termine = FragmentManager.BeginTransaction();
						termine.Replace(Resource.Id.container, new Termine());
						termine.AddToBackStack(null);
						termine.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Termine";
						break;
				//Klausuren
					case 4:
						Android.App.FragmentTransaction klausuren = FragmentManager.BeginTransaction();
						klausuren.Replace(Resource.Id.container, new Klausuren());
						klausuren.AddToBackStack(null);
						klausuren.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Klausuren";
						break;
				//Kontakt
					case 5:
						Android.App.FragmentTransaction kontakt = FragmentManager.BeginTransaction();
						kontakt.Replace(Resource.Id.container, new Kontakt());
						kontakt.AddToBackStack(null);
						kontakt.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Kontakt";
						break;
				//Einstellungen
					case 6:
						Android.App.FragmentTransaction einstellungen = FragmentManager.BeginTransaction();
						einstellungen.Replace(Resource.Id.container, new Einstellungen());
						einstellungen.AddToBackStack(null);
						einstellungen.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Einstellungen";
						break;
				}

			};

			mDrawerLayout.SetDrawerListener(mDrawerToggle);
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeButtonEnabled(true);
			ActionBar.SetDisplayShowTitleEnabled(true);

			//Load RSS-Feed
			try
			{
				var reader = new RSSReader("http://fg-kassel.de/feed/index.php", this);
				reader.DownloadFeed("fg_feed.rss");
			}
			catch
			{
				Android.Widget.Toast.MakeText(this, "RSS-Feed konnte nicht geladen werden.", Android.Widget.ToastLength.Long).Show();
			}
		}

		protected override void OnPostCreate(Bundle savedInstanceState)
		{
			base.OnPostCreate(savedInstanceState);
			mDrawerToggle.SyncState();
		}

		public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			mDrawerToggle.OnConfigurationChanged(newConfig);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (mDrawerToggle.OnOptionsItemSelected(item))
			{
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		//Button-Navigation
		public override bool OnKeyUp(Keycode keyCode, KeyEvent e)
		{
			if (keyCode == Keycode.Menu)
			{
				if (!mDrawerLayout.IsDrawerOpen(mLeftDrawer))
				{
					mDrawerLayout.OpenDrawer(mLeftDrawer);
				}
				else if (mDrawerLayout.IsDrawerOpen(mLeftDrawer))
				{
					mDrawerLayout.CloseDrawer(mLeftDrawer);
				}
				return true;
			}
			else if (keyCode == Keycode.Back)
			{
				if (mDrawerLayout.IsDrawerOpen(mLeftDrawer))
				{
					mDrawerLayout.CloseDrawer(mLeftDrawer);
				}
				else
				{
					Finish();
				}
				return true;
			}
			return base.OnKeyUp(keyCode, e);
		}
	}
}


