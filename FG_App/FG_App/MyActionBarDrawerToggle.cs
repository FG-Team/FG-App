using System;
using Android.Support.V4.App;
using Android.App;
using Android.Support.V4.Widget;


namespace FG_App
{
    
	/// <summary>
	/// Initialisiert eine neue Instanz der MyActionBarDrawerToggle Klasse.
	/// </summary>
	public class MyActionBarDrawerToggle : ActionBarDrawerToggle
	{
		Activity mActivity;

		/// <summary>
		/// Der Konstrutor für MyActionBarDrawerToggle.
		/// </summary>
		/// <param name="activity">Die Aktivität.</param>
		/// <param name="drawerLayout">Das Layout.</param>
		/// <param name="imageResource">Die Quelle.</param>
		/// <param name="openDrawerDesc">Die Öffnungs-Beschreibung.</param>
		/// <param name="closeDrawerDesc">Die SChließungs-Beschreibung.</param>
		public MyActionBarDrawerToggle(Activity activity, DrawerLayout drawerLayout, int imageResource, int openDrawerDesc, int closeDrawerDesc)
			: base(activity, drawerLayout, imageResource, openDrawerDesc, closeDrawerDesc)
		{
			mActivity = activity;
		}

		/// <summary>
		/// Übersteuerung für OnDrawerOpened.
		/// </summary>
		/// <param name="drawerView">Der View.</param>
		public override void OnDrawerOpened(Android.Views.View drawerView)
		{
			base.OnDrawerOpened(drawerView);
			mActivity.ActionBar.Title = "Menü";
		}

		/// <summary>
		/// Übersteuerung für OnCreate.
		/// </summary>
		/// <param name="drawerView">Der View.</param>
		public override void OnDrawerClosed(Android.Views.View drawerView)
		{
			base.OnDrawerClosed(drawerView);
			// mActivity.ActionBar.Title = "FG-App";
		}

		/// <summary>
		/// Übersteuerung für OnCreate.
		/// </summary>
		/// <param name="drawerView">Der View.</param>
		/// <param name="slideOffset">Das Offset.</param>
		public override void OnDrawerSlide(Android.Views.View drawerView, float slideOffset)
		{
			base.OnDrawerSlide(drawerView, slideOffset);
		}
	}

}

