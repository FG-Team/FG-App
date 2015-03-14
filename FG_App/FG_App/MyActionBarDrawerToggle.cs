using System;
using Android.Support.V4.App;
using Android.App;
using Android.Support.V4.Widget;


namespace FG_App
{
	public class MyActionBarDrawerToggle : ActionBarDrawerToggle
	{
		Activity mActivity;
		public MyActionBarDrawerToggle (Activity activity, DrawerLayout drawerLayout, int imageResource, int openDrawerDesc, int closeDrawerDesc)
			:base (activity, drawerLayout, imageResource, openDrawerDesc, closeDrawerDesc)
		{
			mActivity = activity;
		}
		public override void OnDrawerOpened (Android.Views.View drawerView)
		{
			base.OnDrawerOpened (drawerView);
			mActivity.ActionBar.Title = "Menü";
		}

		public override void OnDrawerClosed (Android.Views.View drawerView)
		{
			base.OnDrawerClosed (drawerView);
			// mActivity.ActionBar.Title = "FG-App";
		}

		public override void OnDrawerSlide (Android.Views.View drawerView, float slideOffset)
		{
			base.OnDrawerSlide (drawerView, slideOffset);
		}
	}

}

