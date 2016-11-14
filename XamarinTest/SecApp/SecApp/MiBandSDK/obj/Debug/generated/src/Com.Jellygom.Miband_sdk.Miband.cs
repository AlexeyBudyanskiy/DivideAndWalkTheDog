using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jellygom.Miband_sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']"
	[global::Android.Runtime.Register ("com/jellygom/miband_sdk/Miband", DoNotGenerateAcw=true)]
	public partial class Miband : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jellygom/miband_sdk/Miband", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Miband); }
		}

		protected Miband (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/constructor[@name='Miband' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Miband (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Miband)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetConnect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_Connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothDevice p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("connect", "(Landroid/bluetooth/BluetoothDevice;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetConnect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void Connect (global::Android.Bluetooth.BluetoothDevice p0, global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1)
		{
			if (id_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "connect", "(Landroid/bluetooth/BluetoothDevice;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connect_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Landroid/bluetooth/BluetoothDevice;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetGetBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_GetBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetBatteryLevel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='getBatteryLevel' and count(parameter)=1 and parameter[1][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("getBatteryLevel", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetGetBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void GetBatteryLevel (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0)
		{
			if (id_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "getBatteryLevel", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getBatteryLevel_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBatteryLevel", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetGetCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_GetCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetCurrentSteps (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='getCurrentSteps' and count(parameter)=1 and parameter[1][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("getCurrentSteps", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetGetCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void GetCurrentSteps (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0)
		{
			if (id_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "getCurrentSteps", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getCurrentSteps_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentSteps", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetGetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_GetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetUserInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='getUserInfo' and count(parameter)=1 and parameter[1][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("getUserInfo", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetGetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void GetUserInfo (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0)
		{
			if (id_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "getUserInfo", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfo", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetSearchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SearchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_SearchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothAdapter p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SearchDevice (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='searchDevice' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothAdapter'] and parameter[2][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("searchDevice", "(Landroid/bluetooth/BluetoothAdapter;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetSearchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void SearchDevice (global::Android.Bluetooth.BluetoothAdapter p0, global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1)
		{
			if (id_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "searchDevice", "(Landroid/bluetooth/BluetoothAdapter;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_searchDevice_Landroid_bluetooth_BluetoothAdapter_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchDevice", "(Landroid/bluetooth/BluetoothAdapter;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetSendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_SendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendAlert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='sendAlert' and count(parameter)=1 and parameter[1][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("sendAlert", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetSendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void SendAlert (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p0)
		{
			if (id_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "sendAlert", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendAlert_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAlert", "(Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_;
#pragma warning disable 0169
		static Delegate GetSetHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_Handler ()
		{
			if (cb_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_ == null)
				cb_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_);
			return cb_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_;
		}

		static void n_SetHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListener p0 = (global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListener)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHeartRateScanListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='setHeartRateScanListener' and count(parameter)=1 and parameter[1][@type='com.jellygom.miband_sdk.MiBandIO.Listener.HeartrateListener']]"
		[Register ("setHeartRateScanListener", "(Lcom/jellygom/miband_sdk/MiBandIO/Listener/HeartrateListener;)V", "GetSetHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_Handler")]
		public virtual unsafe void SetHeartRateScanListener (global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListener p0)
		{
			if (id_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_ == IntPtr.Zero)
				id_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_ = JNIEnv.GetMethodID (class_ref, "setHeartRateScanListener", "(Lcom/jellygom/miband_sdk/MiBandIO/Listener/HeartrateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHeartRateScanListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_HeartrateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeartRateScanListener", "(Lcom/jellygom/miband_sdk/MiBandIO/Listener/HeartrateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_;
#pragma warning disable 0169
		static Delegate GetSetRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_Handler ()
		{
			if (cb_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_ == null)
				cb_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_);
			return cb_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_;
		}

		static void n_SetRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener p0 = (global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRealtimeStepListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='setRealtimeStepListener' and count(parameter)=1 and parameter[1][@type='com.jellygom.miband_sdk.MiBandIO.Listener.RealtimeStepListener']]"
		[Register ("setRealtimeStepListener", "(Lcom/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListener;)V", "GetSetRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_Handler")]
		public virtual unsafe void SetRealtimeStepListener (global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener p0)
		{
			if (id_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_ == IntPtr.Zero)
				id_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_ = JNIEnv.GetMethodID (class_ref, "setRealtimeStepListener", "(Lcom/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRealtimeStepListener_Lcom_jellygom_miband_sdk_MiBandIO_Listener_RealtimeStepListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRealtimeStepListener", "(Lcom/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetSetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_SetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetUserInfo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='setUserInfo' and count(parameter)=2 and parameter[1][@type='com.jellygom.miband_sdk.MiBandIO.Model.UserInfo'] and parameter[2][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("setUserInfo", "(Lcom/jellygom/miband_sdk/MiBandIO/Model/UserInfo;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetSetUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void SetUserInfo (global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo p0, global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1)
		{
			if (id_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "setUserInfo", "(Lcom/jellygom/miband_sdk/MiBandIO/Model/UserInfo;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserInfo_Lcom_jellygom_miband_sdk_MiBandIO_Model_UserInfo_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserInfo", "(Lcom/jellygom/miband_sdk/MiBandIO/Model/UserInfo;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetStartHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_StartHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_StartHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Jellygom.Miband_sdk.Miband __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.Miband> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartHeartRateScan (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk']/class[@name='Miband']/method[@name='startHeartRateScan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("startHeartRateScan", "(ILcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetStartHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void StartHeartRateScan (int p0, global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1)
		{
			if (id_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "startHeartRateScan", "(ILcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startHeartRateScan_ILcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startHeartRateScan", "(ILcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListener"
		public event EventHandler<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.HeartrateEventArgs> HeartRateScan {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListener, global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListenerImplementor>(
						ref weak_implementor_SetHeartRateScanListener,
						__CreateIHeartrateListenerImplementor,
						SetHeartRateScanListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListener, global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListenerImplementor>(
						ref weak_implementor_SetHeartRateScanListener,
						global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListenerImplementor.__IsEmpty,
						__v => SetHeartRateScanListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetHeartRateScanListener;

		global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListenerImplementor __CreateIHeartrateListenerImplementor ()
		{
			return new global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IHeartrateListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener"
		public event EventHandler<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.RealtimeStepEventArgs> RealtimeStep {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener, global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerImplementor>(
						ref weak_implementor_SetRealtimeStepListener,
						__CreateIRealtimeStepListenerImplementor,
						SetRealtimeStepListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener, global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerImplementor>(
						ref weak_implementor_SetRealtimeStepListener,
						global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerImplementor.__IsEmpty,
						__v => SetRealtimeStepListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetRealtimeStepListener;

		global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerImplementor __CreateIRealtimeStepListenerImplementor ()
		{
			return new global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerImplementor (this);
		}
#endregion
	}
}
