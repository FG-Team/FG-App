using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Support.V4.Widget;
using Android.Support.V4.App;

namespace FG_App
{
	/// <summary>
	/// Initialisiert eine neue Instanz der Aktuelles Klasse.
	/// </summary>
	[Activity(Label = "FG-App", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/CustomActionBarTheme")]

	public class MainActivity : Activity
	{
		DrawerLayout mDrawerLayout = null;
		List<string> mLeftItems = new List<string>();
		ArrayAdapter mLeftAdapter = null;
		ListView mLeftDrawer = null;
		ActionBarDrawerToggle mDrawerToggle = null;
		public ListView mListView = null;

		/// <summary>
		/// Übersteuerung für OnCreate.
		/// </summary>
		/// <param name="savedInstanceState">Das Bundle.</param>
		protected override void OnCreate(Bundle savedInstanceState)
		{
			//Standard reference
			base.OnCreate(savedInstanceState);

			//Set layout
			SetContentView(Resource.Layout.Main);

			//Set listview
			mListView = FindViewById<ListView>(Resource.Id.myListView);

			//Set drawer
			mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.myDrawer);
			mLeftDrawer = FindViewById<ListView>(Resource.Id.leftListView);

			//Create items for drawer
			mLeftItems.Add("Schule");
			mLeftItems.Add("Aktuelles");
			mLeftItems.Add("SV");
			mLeftItems.Add("Termine");
			mLeftItems.Add("Klausuren");
			mLeftItems.Add("Kontakt");
			mLeftItems.Add("Einstellungen");

			//Set toggles for drawer
			mDrawerToggle =	new MyActionBarDrawerToggle(this, mDrawerLayout, Resource.Drawable.IcNavigationDrawer, Resource.String.open_drawer, Resource.String.close_drawer);
			mLeftAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, mLeftItems);
			mLeftDrawer.Adapter = mLeftAdapter;

			//Set click actions for drawer
			mLeftDrawer.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) =>
			{
				switch (mLeftDrawer.CheckedItemPosition)
				{
				//School - Schule
					case 0:
						Android.App.FragmentTransaction schule = FragmentManager.BeginTransaction();
						schule.Replace(Resource.Id.container, new Schule());
						schule.AddToBackStack(null);
						schule.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Schule";
						break;
				//News - Aktuelles
					case 1:
						Android.App.FragmentTransaction aktuelles = FragmentManager.BeginTransaction();
						aktuelles.Replace(Resource.Id.container, new Aktuelles());
						aktuelles.AddToBackStack(null);
						aktuelles.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Aktuelles";
						break;
				//SR - SV
					case 2:
						Android.App.FragmentTransaction sv = FragmentManager.BeginTransaction();
						sv.Replace(Resource.Id.container, new SV());
						sv.AddToBackStack(null);
						sv.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "SV";
						break;
				//Dates - Termine
					case 3:
						Android.App.FragmentTransaction termine = FragmentManager.BeginTransaction();
						termine.Replace(Resource.Id.container, new Termine());
						termine.AddToBackStack(null);
						termine.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Termine";
						break;
				//Tests - Klausuren
					case 4:
						Android.App.FragmentTransaction klausuren = FragmentManager.BeginTransaction();
						klausuren.Replace(Resource.Id.container, new Klausuren());
						klausuren.AddToBackStack(null);
						klausuren.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Klausuren";
						break;
				//Contact - Kontakt
					case 5:
						Android.App.FragmentTransaction kontakt = FragmentManager.BeginTransaction();
						kontakt.Replace(Resource.Id.container, new Kontakt());
						kontakt.AddToBackStack(null);
						kontakt.Commit();
						mDrawerLayout.CloseDrawer(mLeftDrawer);
						ActionBar.Title = "Kontakt";
						break;
				//Settings - Einstellungen
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

			//Create actionbar
			mDrawerLayout.SetDrawerListener(mDrawerToggle);
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeButtonEnabled(true);
			ActionBar.SetDisplayShowTitleEnabled(true);

			//Load RSS-Feed
			try
			{
				var reader = new RSSReader("http://fg-kassel.de/feed/index.php", this);

				//Set adapter for listview
				ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, reader.DownloadFeed("fg_feed.rss", this));
				mListView.Adapter = adapter;
			}
			catch
			{
				Android.Widget.Toast.MakeText(this, "RSS-Feed konnte nicht geladen werden.", Android.Widget.ToastLength.Long).Show();
			}
		}

		/// <summary>
		/// Override of OnPostCreate.
		/// </summary>
		/// <param name="savedInstanceState">The bundle.</param>
		protected override void OnPostCreate(Bundle savedInstanceState)
		{
			base.OnPostCreate(savedInstanceState);
			mDrawerToggle.SyncState();
		}

		/// <summary>
		/// Override of OnConfigurationChanged.
		/// </summary>
		/// <param name="newConfig">The configuration.</param>
		public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			mDrawerToggle.OnConfigurationChanged(newConfig);
		}

		/// <summary>
		/// Override of OnOptionsItemSelected.
		/// </summary>
		/// <param name="item">The menu item.</param>
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (mDrawerToggle.OnOptionsItemSelected(item))
			{
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		/// <summary>
		/// Override of OnKeyUp for button navigation.
		/// </summary>
		/// <param name="keyCode">The keycode.</param>
		/// <param name="e">The keyevent.</param>
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


