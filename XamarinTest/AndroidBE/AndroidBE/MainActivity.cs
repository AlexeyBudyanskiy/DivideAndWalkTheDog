using System;
using System.Linq;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Robotics.Mobile.Core;
using Robotics.Mobile.Core.Bluetooth.LE;


namespace AndroidBE
{
    [Activity(Label = "AndroidBE", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            Robotics.Mobile.Core.Bluetooth.LE.Adapter adapter = new Robotics.Mobile.Core.Bluetooth.LE.Adapter();
            adapter.StartScanningForDevices(Guid.Empty);

            while (adapter.DiscoveredDevices.Count < 1)
            {
                
            }

            if (adapter.DiscoveredDevices.Count > 0)
            {
                button.Text = adapter.DiscoveredDevices[0].Name;
            }

        }
    }
}

