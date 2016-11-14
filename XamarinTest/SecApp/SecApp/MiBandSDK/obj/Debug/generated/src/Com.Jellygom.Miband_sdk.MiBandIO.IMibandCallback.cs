using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jellygom.Miband_sdk.MiBandIO {

	[Register ("com/jellygom/miband_sdk/MiBandIO/MibandCallback")]
	public abstract class MibandCallback {

		internal MibandCallback ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_CONNECT']"
		[Register ("STATUS_CONNECT")]
		public const int StatusConnect = (int) 243;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_GET_ACTIVITY_DATA']"
		[Register ("STATUS_GET_ACTIVITY_DATA")]
		public const int StatusGetActivityData = (int) 248;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_GET_BATTERY']"
		[Register ("STATUS_GET_BATTERY")]
		public const int StatusGetBattery = (int) 249;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_GET_USERINFO']"
		[Register ("STATUS_GET_USERINFO")]
		public const int StatusGetUserinfo = (int) 241;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_SEARCH_DEVICE']"
		[Register ("STATUS_SEARCH_DEVICE")]
		public const int StatusSearchDevice = (int) 242;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_SEND_ALERT']"
		[Register ("STATUS_SEND_ALERT")]
		public const int StatusSendAlert = (int) 245;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_SET_USERINFO']"
		[Register ("STATUS_SET_USERINFO")]
		public const int StatusSetUserinfo = (int) 244;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/field[@name='STATUS_START_HEARTRATE_SCAN']"
		[Register ("STATUS_START_HEARTRATE_SCAN")]
		public const int StatusStartHeartrateScan = (int) 246;
	}

	[global::System.Obsolete ("Use the 'MibandCallback' type. This type will be removed in a future release.")]
	public abstract class MibandCallbackConsts : MibandCallback {

		private MibandCallbackConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']"
	[Register ("com/jellygom/miband_sdk/MiBandIO/MibandCallback", "", "Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallbackInvoker")]
	public partial interface IMibandCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/method[@name='onFail' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("onFail", "(ILjava/lang/String;I)V", "GetOnFail_ILjava_lang_String_IHandler:Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallbackInvoker, MiBandSDK")]
		void OnFail (int p0, string p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO']/interface[@name='MibandCallback']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("onSuccess", "(Ljava/lang/Object;I)V", "GetOnSuccess_Ljava_lang_Object_IHandler:Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallbackInvoker, MiBandSDK")]
		void OnSuccess (global::Java.Lang.Object p0, int p1);

	}

	[global::Android.Runtime.Register ("com/jellygom/miband_sdk/MiBandIO/MibandCallback", DoNotGenerateAcw=true)]
	internal class IMibandCallbackInvoker : global::Java.Lang.Object, IMibandCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jellygom/miband_sdk/MiBandIO/MibandCallback");
		IntPtr class_ref;

		public static IMibandCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMibandCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jellygom.miband_sdk.MiBandIO.MibandCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMibandCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMibandCallbackInvoker); }
		}

		static Delegate cb_onFail_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnFail_ILjava_lang_String_IHandler ()
		{
			if (cb_onFail_ILjava_lang_String_I == null)
				cb_onFail_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int>) n_OnFail_ILjava_lang_String_I);
			return cb_onFail_ILjava_lang_String_I;
		}

		static void n_OnFail_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFail (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onFail_ILjava_lang_String_I;
		public unsafe void OnFail (int p0, string p1, int p2)
		{
			if (id_onFail_ILjava_lang_String_I == IntPtr.Zero)
				id_onFail_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onFail", "(ILjava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_onFail_ILjava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_IHandler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_I == null)
				cb_onSuccess_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnSuccess_Ljava_lang_Object_I);
			return cb_onSuccess_Ljava_lang_Object_I;
		}

		static void n_OnSuccess_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.IMibandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_I;
		public unsafe void OnSuccess (global::Java.Lang.Object p0, int p1)
		{
			if (id_onSuccess_Ljava_lang_Object_I == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Ljava_lang_Object_I, __args);
		}

	}

}
