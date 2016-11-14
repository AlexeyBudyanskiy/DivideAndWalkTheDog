using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jellygom.Miband_sdk.MiBandIO.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']"
	[global::Android.Runtime.Register ("com/jellygom/miband_sdk/MiBandIO/Model/MibandUUID", DoNotGenerateAcw=true)]
	public partial class MibandUUID : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='MAC_FILTER_MI1S']"
		[Register ("MAC_FILTER_MI1S")]
		public const string MacFilterMi1s = (string) "C8:0F:10";

		static IntPtr UUID_CHARACTERISTIC_ALERT_LEVEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_CHARACTERISTIC_ALERT_LEVEL']"
		[Register ("UUID_CHARACTERISTIC_ALERT_LEVEL")]
		public static global::Java.Util.UUID UuidCharacteristicAlertLevel {
			get {
				if (UUID_CHARACTERISTIC_ALERT_LEVEL_jfieldId == IntPtr.Zero)
					UUID_CHARACTERISTIC_ALERT_LEVEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_CHARACTERISTIC_ALERT_LEVEL", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_CHARACTERISTIC_ALERT_LEVEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_CHARACTERISTIC_BATTERY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_CHARACTERISTIC_BATTERY']"
		[Register ("UUID_CHARACTERISTIC_BATTERY")]
		public static global::Java.Util.UUID UuidCharacteristicBattery {
			get {
				if (UUID_CHARACTERISTIC_BATTERY_jfieldId == IntPtr.Zero)
					UUID_CHARACTERISTIC_BATTERY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_CHARACTERISTIC_BATTERY", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_CHARACTERISTIC_BATTERY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT']"
		[Register ("UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT")]
		public static global::Java.Util.UUID UuidCharacteristicHeartRateControlPoint {
			get {
				if (UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT_jfieldId == IntPtr.Zero)
					UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_CHARACTERISTIC_HEART_RATE_CONTROL_POINT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT']"
		[Register ("UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT")]
		public static global::Java.Util.UUID UuidCharacteristicHeartRateMeasurement {
			get {
				if (UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT_jfieldId == IntPtr.Zero)
					UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_CHARACTERISTIC_HEART_RATE_MEASUREMENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_CHARACTERISTIC_REALTIME_STEPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_CHARACTERISTIC_REALTIME_STEPS']"
		[Register ("UUID_CHARACTERISTIC_REALTIME_STEPS")]
		public static global::Java.Util.UUID UuidCharacteristicRealtimeSteps {
			get {
				if (UUID_CHARACTERISTIC_REALTIME_STEPS_jfieldId == IntPtr.Zero)
					UUID_CHARACTERISTIC_REALTIME_STEPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_CHARACTERISTIC_REALTIME_STEPS", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_CHARACTERISTIC_REALTIME_STEPS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_CHARACTERISTIC_USER_INFO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_CHARACTERISTIC_USER_INFO']"
		[Register ("UUID_CHARACTERISTIC_USER_INFO")]
		public static global::Java.Util.UUID UuidCharacteristicUserInfo {
			get {
				if (UUID_CHARACTERISTIC_USER_INFO_jfieldId == IntPtr.Zero)
					UUID_CHARACTERISTIC_USER_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_CHARACTERISTIC_USER_INFO", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_CHARACTERISTIC_USER_INFO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_DESCRIPTOR_UPDATE_NOTIFICATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_DESCRIPTOR_UPDATE_NOTIFICATION']"
		[Register ("UUID_DESCRIPTOR_UPDATE_NOTIFICATION")]
		public static global::Java.Util.UUID UuidDescriptorUpdateNotification {
			get {
				if (UUID_DESCRIPTOR_UPDATE_NOTIFICATION_jfieldId == IntPtr.Zero)
					UUID_DESCRIPTOR_UPDATE_NOTIFICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_DESCRIPTOR_UPDATE_NOTIFICATION", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_DESCRIPTOR_UPDATE_NOTIFICATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_SERVICE_ALERT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_SERVICE_ALERT']"
		[Register ("UUID_SERVICE_ALERT")]
		public static global::Java.Util.UUID UuidServiceAlert {
			get {
				if (UUID_SERVICE_ALERT_jfieldId == IntPtr.Zero)
					UUID_SERVICE_ALERT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_SERVICE_ALERT", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_SERVICE_ALERT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_SERVICE_HEART_RATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_SERVICE_HEART_RATE']"
		[Register ("UUID_SERVICE_HEART_RATE")]
		public static global::Java.Util.UUID UuidServiceHeartRate {
			get {
				if (UUID_SERVICE_HEART_RATE_jfieldId == IntPtr.Zero)
					UUID_SERVICE_HEART_RATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_SERVICE_HEART_RATE", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_SERVICE_HEART_RATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_SERVICE_MIBAND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/field[@name='UUID_SERVICE_MIBAND']"
		[Register ("UUID_SERVICE_MIBAND")]
		public static global::Java.Util.UUID UuidServiceMiband {
			get {
				if (UUID_SERVICE_MIBAND_jfieldId == IntPtr.Zero)
					UUID_SERVICE_MIBAND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_SERVICE_MIBAND", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_SERVICE_MIBAND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jellygom/miband_sdk/MiBandIO/Model/MibandUUID", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MibandUUID); }
		}

		protected MibandUUID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jellygom.miband_sdk.MiBandIO.Model']/class[@name='MibandUUID']/constructor[@name='MibandUUID' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MibandUUID ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MibandUUID)) {
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

	}
}
