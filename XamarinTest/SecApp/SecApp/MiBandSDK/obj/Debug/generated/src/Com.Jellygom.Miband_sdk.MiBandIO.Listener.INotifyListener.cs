using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jellygom.Miband_sdk.MiBandIO.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Listener']/interface[@name='NotifyListener']"
	[Register ("com/jellygom/miband_sdk/MiBandIO/Listener/NotifyListener", "", "Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListenerInvoker")]
	public partial interface INotifyListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Listener']/interface[@name='NotifyListener']/method[@name='onNotify' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onNotify", "([B)V", "GetOnNotify_arrayBHandler:Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListenerInvoker, MiBandSDK")]
		void OnNotify (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/jellygom/miband_sdk/MiBandIO/Listener/NotifyListener", DoNotGenerateAcw=true)]
	internal class INotifyListenerInvoker : global::Java.Lang.Object, INotifyListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jellygom/miband_sdk/MiBandIO/Listener/NotifyListener");
		IntPtr class_ref;

		public static INotifyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INotifyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jellygom.miband_sdk.MiBandIO.Listener.NotifyListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INotifyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INotifyListenerInvoker); }
		}

		static Delegate cb_onNotify_arrayB;
#pragma warning disable 0169
		static Delegate GetOnNotify_arrayBHandler ()
		{
			if (cb_onNotify_arrayB == null)
				cb_onNotify_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNotify_arrayB);
			return cb_onNotify_arrayB;
		}

		static void n_OnNotify_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnNotify (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onNotify_arrayB;
		public unsafe void OnNotify (byte[] p0)
		{
			if (id_onNotify_arrayB == IntPtr.Zero)
				id_onNotify_arrayB = JNIEnv.GetMethodID (class_ref, "onNotify", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onNotify_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	public partial class NotifyEventArgs : global::System.EventArgs {

		public NotifyEventArgs (byte[] p0)
		{
			this.p0 = p0;
		}

		byte[] p0;
		public byte[] P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/jellygom/miband_sdk/MiBandIO/Listener/NotifyListenerImplementor")]
	internal sealed partial class INotifyListenerImplementor : global::Java.Lang.Object, INotifyListener {

		object sender;

		public INotifyListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/jellygom/miband_sdk/MiBandIO/Listener/NotifyListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<NotifyEventArgs> Handler;
#pragma warning restore 0649

		public void OnNotify (byte[] p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new NotifyEventArgs (p0));
		}

		internal static bool __IsEmpty (INotifyListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
