package mono.com.jellygom.miband_sdk.MiBandIO.Listener;


public class RealtimeStepListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.jellygom.miband_sdk.MiBandIO.Listener.RealtimeStepListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onNotify:(I)V:GetOnNotify_IHandler:Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerInvoker, MiBandSDK\n" +
			"";
		mono.android.Runtime.register ("Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerImplementor, MiBandSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RealtimeStepListenerImplementor.class, __md_methods);
	}


	public RealtimeStepListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RealtimeStepListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Jellygom.Miband_sdk.MiBandIO.Listener.IRealtimeStepListenerImplementor, MiBandSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onNotify (int p0)
	{
		n_onNotify (p0);
	}

	private native void n_onNotify (int p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
