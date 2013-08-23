using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Mileage
{
	[Activity (Label = "Mileage", MainLauncher = true)]
	public class MainActivity : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {

				var SecondPage = new Intent(this, typeof(second));
				StartActivityForResult(SecondPage,0);
			};
		}
		public void test(Action<bool> callback,string message)
		{
			AlertDialog.Builder builder = new AlertDialog.Builder(this);
			builder.SetTitle(Android.Resource.String.DialogAlertTitle);
			builder.SetIcon(Android.Resource.Drawable.IcDialogAlert);
			builder.SetMessage(message);
			builder.SetPositiveButton("OK", (sender, e) => {callback(true);});

			builder.Show();
		}
	}
}


