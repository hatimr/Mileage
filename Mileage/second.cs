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

namespace Mileage
{
	[Activity (Label = "second")]			
	public class second : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			const int PreviousReading = 20;
			int mileage = 0;
			SetContentView (Resource.Layout.second);

			EditText OdometerCurrentReading = FindViewById<EditText> (Resource.Id.editText1);
			EditText FuelRefill = FindViewById<EditText> (Resource.Id.editText2);
			EditText AmountRefilled = FindViewById<EditText> (Resource.Id.editText3);

			Button myButton = FindViewById<Button> (Resource.Id.button1);



			myButton.Click += (sender, e) => {
				int abc = int.Parse (OdometerCurrentReading.Text);
				int fuel = int.Parse (FuelRefill.Text);
				mileage = ((abc-PreviousReading)/fuel);
				TextView result = FindViewById<TextView> (Resource.Id.textView4);
				result.Text = "Mileage = " + mileage;
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

