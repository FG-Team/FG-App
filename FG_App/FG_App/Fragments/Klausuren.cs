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
	/// Initialisiert eine neue Instanz der Klausuren Klasse.
	/// </summary>
    public class Klausuren : Fragment
	{
        private Button mBtnKlausurenE2;
        private Button mBtnKlausurenQ2;
        private Button mBtnKlausurenQ4;
		/// <summary>
		/// Übersteuerung für OnCreateView.
		/// </summary>
		/// <param name="inflater">Der Inflater.</param>
		/// <param name="container">Die ViewGroup.</param>
		/// <param name="savedInstanceState">Das Bundle.</param>
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.Klausuren, container, false);

            mBtnKlausurenE2 = view.FindViewById<Button>(Resource.Id.KlausurenE2Btn);
            mBtnKlausurenQ2 = view.FindViewById<Button>(Resource.Id.KlausurenQ2Btn);
            mBtnKlausurenQ4 = view.FindViewById<Button>(Resource.Id.KlausurenQ4Btn);

            mBtnKlausurenE2.Click += (object sender, EventArgs e) => 
                Console.WriteLine("Hello");

            mBtnKlausurenQ2.Click += (object sender, EventArgs e) => 
                Console.WriteLine("Q2");

            mBtnKlausurenQ4.Click += (object sender, EventArgs e) => 
                Console.WriteLine("Q4");

            return view;
		}



	}
}

