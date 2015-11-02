
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
	[BroadcastReceiver]
	public class InitBroadcast : BroadcastReceiver
	{
		public override void OnReceive (Context context, Intent intent)
		{
			Toast.MakeText (context, "Received intent!", ToastLength.Short).Show ();
		}
	}
}

[Import InitBroadcast]
from InitBroadcast 
	private dynamic extern InfinReciever
	{
		public override void OnBroadcast(Context context, Intent intent)
		{
		
		}
	}