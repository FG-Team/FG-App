
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FG_App
{
	[Activity (Label = "Einstellungen_Fragment")]			
	public class Einstellungen_Fragment : Fragment
	{
		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{

			View einstellungen = inflater.Inflate (Resource.Layout.Einstellungen, container, false);
			return einstellungen;
		}
	}
}

