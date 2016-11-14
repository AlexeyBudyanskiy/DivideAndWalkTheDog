using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jellygom.Miband_sdk.MiBandIO.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='UserInfo']"
	[global::Android.Runtime.Register ("com/jellygom/miband_sdk/MiBandIO/Model/UserInfo", DoNotGenerateAcw=true)]
	public partial class UserInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jellygom/miband_sdk/MiBandIO/Model/UserInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserInfo); }
		}

		protected UserInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='UserInfo']/constructor[@name='UserInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UserInfo)) {
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

		static Delegate cb_fromByteData_arrayB;
#pragma warning disable 0169
		static Delegate GetFromByteData_arrayBHandler ()
		{
			if (cb_fromByteData_arrayB == null)
				cb_fromByteData_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromByteData_arrayB);
			return cb_fromByteData_arrayB;
		}

		static IntPtr n_FromByteData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromByteData (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fromByteData_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='UserInfo']/method[@name='fromByteData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("fromByteData", "([B)Lcom/jellygom/miband_sdk/MiBandIO/Model/UserInfo;", "GetFromByteData_arrayBHandler")]
		public virtual unsafe global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo FromByteData (byte[] p0)
		{
			if (id_fromByteData_arrayB == IntPtr.Zero)
				id_fromByteData_arrayB = JNIEnv.GetMethodID (class_ref, "fromByteData", "([B)Lcom/jellygom/miband_sdk/MiBandIO/Model/UserInfo;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo> (JNIEnv.CallObjectMethod  (Handle, id_fromByteData_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromByteData", "([B)Lcom/jellygom/miband_sdk/MiBandIO/Model/UserInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getBytes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBytes_Ljava_lang_String_Handler ()
		{
			if (cb_getBytes_Ljava_lang_String_ == null)
				cb_getBytes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBytes_Ljava_lang_String_);
			return cb_getBytes_Ljava_lang_String_;
		}

		static IntPtr n_GetBytes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jellygom.Miband_sdk.MiBandIO.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBytes (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBytes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='UserInfo']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytes", "(Ljava/lang/String;)[B", "GetGetBytes_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] GetBytes (string p0)
		{
			if (id_getBytes_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBytes", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBytes_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
