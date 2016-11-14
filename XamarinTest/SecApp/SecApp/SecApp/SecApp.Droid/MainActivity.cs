using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Provider;
using Com.Jellygom.Miband_sdk;
using Com.Jellygom.Miband_sdk.MiBandIO;
using Object = Java.Lang.Object;
using Robotics.Mobile.Core.Bluetooth.LE;
using Adapter = Robotics.Mobile.Core.Bluetooth.LE.Adapter;

namespace SecApp.Droid
{
    [Activity(Label = "SecApp.Droid", MainLauncher = true, Icon = "@drawable/icon")]
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
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
            };

            

            //Miband miband = new Miband(this);
            //BluetoothAdapter bluetoothAdapter = ((BluetoothManager) GetSystemService(Context.BluetoothService)).Adapter;
            //miband.SearchDevice(bluetoothAdapter, new MyMiBandCallBack());

            //if (bluetoothAdapter.BondedDevices.Count > 0)
            //{
            //    miband.Connect(bluetoothAdapter.BondedDevices.ToList()[0],new MyMiBandCallBack());
            //}

            Adapter adapter = new Adapter();
            adapter.StartScanningForDevices();
            while(true)
                if (adapter.DiscoveredDevices.Count > 1)
                {
                    button.Text += adapter.DiscoveredDevices[0].Name;
                    break;
                }
                    

            adapter.StopScanningForDevices();

            //if (adapter == null)
            //    throw new Exception("No Bluetooth adapter found.");

            //if (!adapter.IsEnabled)
            //    throw new Exception("Bluetooth adapter is not enabled.");

            //button.Text = "";

            //LeScanCallBack callBack = new LeScanCallBack(button);
            //adapter.StartDiscovery();
            

            //while (true)
            //    if(callBack.devicelist.Count > 1)
            //        break;

            //adapter.StopLeScan(callBack);

            
            //foreach (var device in adapter.BondedDevices)
            //{
            //    button.Text += device.Name;
            //}

            //BluetoothDevice device = (from bd in adapter.BondedDevices
            //                          where bd.Name == "NameOfTheDevice"
            //                          select bd).FirstOrDefault();

            //if (device == null)
            //    throw new Exception("Named device not found.");

        }



        // 
    }

    public class LeScanCallBack: BluetoothAdapter.ILeScanCallback
    {
        private Button button;
        public List<BluetoothDevice> devicelist = new List<BluetoothDevice>();
        public LeScanCallBack(Button button)
        {
            this.button = button;
        }
        public void Dispose()
        {
            Dispose();
        }

        public IntPtr Handle { get; }
        public void OnLeScan(BluetoothDevice device, int rssi, byte[] scanRecord)
        {
            button.Text += device.Name;
            devicelist.Add(device);
        }
    }

    public class MyMiBandCallBack : IMibandCallback
    {
        public void Dispose()
        {
            Dispose();
        }

        public IntPtr Handle { get; }
        public void OnFail(int p0, string p1, int p2)
        {
            Console.WriteLine("Fail");
        }   

        public void OnSuccess(Object p0, int p1)
        {
            
        }
    }
}


