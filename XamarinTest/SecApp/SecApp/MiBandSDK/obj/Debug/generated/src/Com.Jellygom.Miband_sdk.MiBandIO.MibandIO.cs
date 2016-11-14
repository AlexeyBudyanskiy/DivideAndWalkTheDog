using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jellygom.Miband_sdk.MiBandIO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']"
	[global::Android.Runtime.Register ("com/jellygom/miband_sdk/MiBandIO/MibandIO", DoNotGenerateAcw=true)]
	public partial class MibandIO : global::Android.Bluetooth.BluetoothGattCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jellygom/miband_sdk/MiBandIO/MibandIO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MibandIO); }
		}

		protected MibandIO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']/constructor[@name='MibandIO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MibandIO ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MibandIO)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevice);
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		static IntPtr id_getDevice;
		public virtual unsafe global::Android.Bluetooth.BluetoothDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Landroid/bluetooth/BluetoothDevice;", "GetGetDeviceHandler")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Landroid/bluetooth/BluetoothDevice;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallObjectMethod  (Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDevice", "()Landroid/bluetooth/BluetoothDevice;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetConnect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_Connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothDevice p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p2 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.bluetooth.BluetoothDevice'] and parameter[3][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("connect", "(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetConnect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void Connect (global::Android.Content.Context p0, global::Android.Bluetooth.BluetoothDevice p1, global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p2)
		{
			if (id_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "connect", "(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connect_Landroid_content_Context_Landroid_bluetooth_BluetoothDevice_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Landroid/content/Context;Landroid/bluetooth/BluetoothDevice;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetReadCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_ReadCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReadCharacteristic (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']/method[@name='readCharacteristic' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("readCharacteristic", "(Ljava/util/UUID;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetReadCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void ReadCharacteristic (global::Java.Util.UUID p0, global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p1)
		{
			if (id_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "readCharacteristic", "(Ljava/util/UUID;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_readCharacteristic_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readCharacteristic", "(Ljava/util/UUID;Lcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_;
#pragma warning disable 0169
		static Delegate GetSetNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_Handler ()
		{
			if (cb_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_ == null)
				cb_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_);
			return cb_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_;
		}

		static void n_SetNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListener p2 = (global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListener)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetNotifyListener (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']/method[@name='setNotifyListener' and count(parameter)=3 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.jellygom.miband_sdk.MiBandIO.Listener.NotifyListener']]"
		[Register ("setNotifyListener", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/jellygom/miband_sdk/MiBandIO/Listener/NotifyListener;)V", "GetSetNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_Handler")]
		public virtual unsafe void SetNotifyListener (global::Java.Util.UUID p0, global::Java.Util.UUID p1, global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListener p2)
		{
			if (id_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_ == IntPtr.Zero)
				id_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_ = JNIEnv.GetMethodID (class_ref, "setNotifyListener", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/jellygom/miband_sdk/MiBandIO/Listener/NotifyListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNotifyListener_Ljava_util_UUID_Ljava_util_UUID_Lcom_jellygom_miband_sdk_MiBandIO_Listener_NotifyListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotifyListener", "(Ljava/util/UUID;Ljava/util/UUID;Lcom/jellygom/miband_sdk/MiBandIO/Listener/NotifyListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStatus_I;
#pragma warning disable 0169
		static Delegate GetSetStatus_IHandler ()
		{
			if (cb_setStatus_I == null)
				cb_setStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatus_I);
			return cb_setStatus_I;
		}

		static void n_SetStatus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatus", "(I)V", "GetSetStatus_IHandler")]
		public virtual unsafe void SetStatus (int p0)
		{
			if (id_setStatus_I == IntPtr.Zero)
				id_setStatus_I = JNIEnv.GetMethodID (class_ref, "setStatus", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStatus_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
#pragma warning disable 0169
		static Delegate GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler ()
		{
			if (cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == null)
				cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_);
			return cb_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		}

		static void n_WriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.MibandIO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p3 = (global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback)global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.WriteCharacteristic (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/class[@name='MibandIO']/method[@name='writeCharacteristic' and count(parameter)=4 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.jellygom.miband_sdk.MiBandIO.MibandCallback']]"
		[Register ("writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V", "GetWriteCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_Handler")]
		public virtual unsafe void WriteCharacteristic (global::Java.Util.UUID p0, global::Java.Util.UUID p1, byte[] p2, global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback p3)
		{
			if (id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ == IntPtr.Zero)
				id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_ = JNIEnv.GetMethodID (class_ref, "writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeCharacteristic_Ljava_util_UUID_Ljava_util_UUID_arrayBLcom_jellygom_miband_sdk_MiBandIO_MibandCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeCharacteristic", "(Ljava/util/UUID;Ljava/util/UUID;[BLcom/jellygom/miband_sdk/MiBandIO/MibandCallback;)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
