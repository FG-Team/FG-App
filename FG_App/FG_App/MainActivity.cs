using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Support.V4.Widget;
using Android.Support.V4.App;

namespace FG_App
{
	[Activity (Label = "FG-App", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/CustomActionBarTheme")]
	public class MainActivity : Activity
	{
		DrawerLayout mDrawerLayout;
		List<string> mLeftItems = new List<string>();
		ArrayAdapter mLeftAdapter;
		ListView mLeftDrawer;
		ActionBarDrawerToggle mDrawerToggle;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			mDrawerLayout = FindViewById<DrawerLayout> (Resource.Id.myDrawer);
			mLeftDrawer = FindViewById<ListView> (Resource.Id.leftListView);

			mLeftItems.Add ("Unsere Schule");
			mLeftItems.Add ("Aktuelles");
			mLeftItems.Add ("Die SV");
			mLeftItems.Add ("Termine");
			mLeftItems.Add ("Klausuren");
			mLeftItems.Add ("Kontakt");
			mLeftItems.Add ("Einstellungen");

			mDrawerToggle =	new MyActionBarDrawerToggle (this, mDrawerLayout, Resource.Drawable.ic_navigation_drawer, Resource.String.open_drawer, Resource.String.close_drawer);
			mLeftAdapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleListItem1, mLeftItems);
			mLeftDrawer.Adapter = mLeftAdapter;

			mLeftDrawer.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				switch (mLeftDrawer.CheckedItemPosition)
				{
				//Unsere Schule
				case 0:
					Android.App.FragmentTransaction transaction = FragmentManager.BeginTransaction();
					dialog_SignUp signUpDialog = new dialog_SignUp ();
					signUpDialog.Show(transaction, "dialog fragment");
					break;
				//Aktuelles
				case 1:
					Android.App.FragmentTransaction aktuelles = FragmentManager.BeginTransaction();
					aktuelles.Replace(Resource.Id.container, new Aktuelles_Fragment());
					aktuelles.AddToBackStack(null);
					aktuelles.Commit();
					mDrawerLayout.CloseDrawer (mLeftDrawer);
					ActionBar.Title ="Aktuelles";
					break;
				//Die SV
				case 2:
					Android.App.FragmentTransaction diesv = FragmentManager.BeginTransaction();
					diesv.Replace(Resource.Id.container, new diesv());
					diesv.AddToBackStack(null);
					diesv.Commit();
					mDrawerLayout.CloseDrawer (mLeftDrawer);
					ActionBar.Title = "Die SV";
					break;
				//Termine
				case 3:
					Android.Widget.Toast.MakeText (this, "Dominik hat keine Beine!", Android.Widget.ToastLength.Short).Show();
					break;
				//Klausuren
				case 4:
					Android.Widget.Toast.MakeText (this, "Dominiks Haare sehen scheiße aus!", Android.Widget.ToastLength.Short).Show();
					break;
				//Kontakt
				case 5:
					Android.Widget.Toast.MakeText (this, "DOMINIK STINKT!", Android.Widget.ToastLength.Short).Show();
					break;
				//Einstellungen
				case 6:
					Android.Widget.Toast.MakeText (this, "Dominique Seiss", Android.Widget.ToastLength.Short).Show();
					break;
				}

					
			};


			mDrawerLayout.SetDrawerListener (mDrawerToggle);
			ActionBar.SetDisplayHomeAsUpEnabled (true);
			ActionBar.SetHomeButtonEnabled (true);
			ActionBar.SetDisplayShowTitleEnabled (true);


		}



		protected override void OnPostCreate (Bundle savedInstanceState)
		{
			base.OnPostCreate (savedInstanceState);
			mDrawerToggle.SyncState ();

		}

		public override void OnConfigurationChanged (Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged (newConfig);
			mDrawerToggle.OnConfigurationChanged (newConfig);
		}
		public override bool OnOptionsItemSelected (IMenuItem item)
		{

			if (mDrawerToggle.OnOptionsItemSelected (item)) 
			{
				return true;
			}

		
			return base.OnOptionsItemSelected (item);


		
		}
	}
}


