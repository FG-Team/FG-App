
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
	public class Aktuelles_Fragment : Fragment
	{
		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{

			View aktuelles = inflater.Inflate (Resource.Layout.Aktuelles_Fragment, container, false);
			return aktuelles;
		}
	}
}

