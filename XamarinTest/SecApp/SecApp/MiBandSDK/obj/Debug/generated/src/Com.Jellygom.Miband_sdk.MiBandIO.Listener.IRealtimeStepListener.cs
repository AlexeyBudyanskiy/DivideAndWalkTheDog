using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jellygom.Miband_sdk.MiBandIO.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Listener']/interface[@name='RealtimeStepListener']"
	[Register ("com/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListener", "", "Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerInvoker")]
	public partial interface IRealtimeStepListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Listener']/interface[@name='RealtimeStepListener']/method[@name='onNotify' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onNotify", "(I)V", "GetOnNotify_IHandler:Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerInvoker, MiBandSDK")]
		void OnNotify (int p0);

	}

	[global::Android.Runtime.Register ("com/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListener", DoNotGenerateAcw=true)]
	internal class IRealtimeStepListenerInvoker : global::Java.Lang.Object, IRealtimeStepListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListener");
		IntPtr class_ref;

		public static IRealtimeStepListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRealtimeStepListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jellygom.miband_sdk.MiBandIO.Listener.RealtimeStepListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRealtimeStepListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRealtimeStepListenerInvoker); }
		}

		static Delegate cb_onNotify_I;
#pragma warning disable 0169
		static Delegate GetOnNotify_IHandler ()
		{
			if (cb_onNotify_I == null)
				cb_onNotify_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnNotify_I);
			return cb_onNotify_I;
		}

		static void n_OnNotify_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNotify (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNotify_I;
		public unsafe void OnNotify (int p0)
		{
			if (id_onNotify_I == IntPtr.Zero)
				id_onNotify_I = JNIEnv.GetMethodID (class_ref, "onNotify", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onNotify_I, __args);
		}

	}

	public partial class RealtimeStepEventArgs : global::System.EventArgs {

		public RealtimeStepEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListenerImplementor")]
	internal sealed partial class IRealtimeStepListenerImplementor : global::Java.Lang.Object, IRealtimeStepListener {

		object sender;

		public IRealtimeStepListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/jellygom/miband_sdk/MiBandIO/Listener/RealtimeStepListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RealtimeStepEventArgs> Handler;
#pragma warning restore 0649

		public void OnNotify (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new RealtimeStepEventArgs (p0));
		}

		internal static bool __IsEmpty (IRealtimeStepListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
