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
	/// Stellt eine Basis für Newfeed Kontakt dar.
	/// </summary>
	public class Kontakt : Fragment
	{
		/// <summary>
		/// Übersteuerung für OnCreateView.
		/// </summary>
		/// <param name="inflater">Der Inflater.</param>
		/// <param name="container">Die ViewGroup.</param>
		/// <param name="savedInstanceState">Das Bundle.</param>
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View kontakt = inflater.Inflate(Resource.Layout.Kontakt, container, false);
			return kontakt;
		}
	}
}

