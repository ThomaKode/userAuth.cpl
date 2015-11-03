
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

namespace userAuth.cpl.Droid
{
	[Activity (Label = "userAuth.cpl.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.Density | Android.Content.PM.ConfigChanges.Touchscreen)]			
	public class MainActivity : global::Xamarin.Forms.Platform.Android.ActivityIndicatorRenderer 

	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
			// Create your apponlication here
		}
	}
}

