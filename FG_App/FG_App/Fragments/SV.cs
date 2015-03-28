﻿using System;
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
	/// Initialisiert eine neue Instanz der SV Klasse.
	/// </summary>
	public class SV : Fragment
	{
		/// <summary>
		/// Übersteuerung für OnCreateView.
		/// </summary>
		/// <param name="inflater">Der Inflater.</param>
		/// <param name="container">Die ViewGroup.</param>
		/// <param name="savedInstanceState">Das Bundle.</param>
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View diesv = inflater.Inflate(Resource.Layout.SV, container, false);
			return diesv;
		}
	}
}

