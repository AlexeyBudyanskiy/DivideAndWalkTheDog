using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace MobileApp
{
    [Activity(Label = "MobileApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            
            AddEventForMapButtons();
            AddEventsForCallButtons();
        }

        private void AddEventForMapButtons()
        {
            Button button = FindViewById<Button>(Resource.Id.btn_showMap1);

            button.Click += delegate
            {
                var geoUri = Android.Net.Uri.Parse("geo:50.013453, 36.227307");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            button = FindViewById<Button>(Resource.Id.btn_showMap2);

            button.Click += delegate
            {
                var geoUri = Android.Net.Uri.Parse("geo:50.013126, 36.244021");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            button = FindViewById<Button>(Resource.Id.btn_showMap3);

            button.Click += delegate
            {
                var geoUri = Android.Net.Uri.Parse("geo:50.022594, 36.227282");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            button = FindViewById<Button>(Resource.Id.btn_showMap4);

            button.Click += delegate
            {
                var geoUri = Android.Net.Uri.Parse("geo:50.016430, 36.226146");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };

            button = FindViewById<Button>(Resource.Id.btn_showMap5);

            button.Click += delegate
            {
                var geoUri = Android.Net.Uri.Parse("geo:49.989121, 36.243054");
                var mapIntent = new Intent(Intent.ActionView, geoUri);
                StartActivity(mapIntent);
            };
        }

        private void AddEventsForCallButtons()
        {
            var callButton = FindViewById<Button>(Resource.Id.btn_Call);
            AddCallEvent(callButton);

            callButton = FindViewById<Button>(Resource.Id.btn_Call2);
            AddCallEvent(callButton);

            callButton = FindViewById<Button>(Resource.Id.btn_Call3);
            AddCallEvent(callButton);

            callButton = FindViewById<Button>(Resource.Id.btn_Call4);
            AddCallEvent(callButton);

            callButton = FindViewById<Button>(Resource.Id.btn_Call5);
            AddCallEvent(callButton);
        }

        private void AddCallEvent(Button button)
        {
            button.Click += (object sender, EventArgs e) =>
            {
                var callDialog = new AlertDialog.Builder(this);
                callDialog.SetMessage("Call " + "+380505123579" + "?");
                callDialog.SetNeutralButton("Call", delegate {

                    var callIntent = new Intent(Intent.ActionCall);
                    callIntent.SetData(Android.Net.Uri.Parse("tel:" + "+380505123579"));
                    StartActivity(callIntent);
                });
                callDialog.SetNegativeButton("Cancel", delegate { });

                callDialog.Show();
            };
        }
    }
}

