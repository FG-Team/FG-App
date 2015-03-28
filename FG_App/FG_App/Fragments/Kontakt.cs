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
		/// Stellt eine Basis für Newfeed Kontakt dar.
		/// </summary>
		/// <param name="inflater">Der Layoutinflater.</param>
		/// <param name="container">Die Viewgroup.</param>
		/// <param name="savedInstanceState">Das Bundle.</param>
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View kontakt = inflater.Inflate(Resource.Layout.Kontakt, container, false);
			return kontakt;
		}
	}
}

