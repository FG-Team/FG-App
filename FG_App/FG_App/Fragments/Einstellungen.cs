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
	/// <summary>
	/// Initialisiert eine neue Instanz der Einstellungen Klasse.
	/// </summary>
	public class Einstellungen : Fragment
	{
		/// <summary>
		/// Übersteuerung für OnCreateView.
		/// </summary>
		/// <param name="inflater">Der Layoutinflater.</param>
		/// <param name="container">Die Viewgroup.</param>
		/// <param name="savedInstanceState">Das Bundle.</param>
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View einstellungen = inflater.Inflate(Resource.Layout.Einstellungen, container, false);
			return einstellungen;
		}
	}
}

