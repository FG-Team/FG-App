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
	/// Initialisiert eine neue Instanz der dialog_SignUp Klasse.
	/// </summary>
	public class dialog_SignUp : DialogFragment
	{
		/// <summary>
		/// Übersteuerung für OnCreateView.
		/// </summary>
		/// <param name="inflater">Der Inflater.</param>
		/// <param name="container">Die ViewGroup.</param>
		/// <param name="savedInstanceState">Das Bundle.</param>
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView(inflater, container, savedInstanceState);
			var view = inflater.Inflate(Resource.Layout.Schule, container, false);
			return view;
		}
	}
}

