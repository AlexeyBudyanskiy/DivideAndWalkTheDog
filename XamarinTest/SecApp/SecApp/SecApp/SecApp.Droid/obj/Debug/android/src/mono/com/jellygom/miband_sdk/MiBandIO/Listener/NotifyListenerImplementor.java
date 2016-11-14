package mono.com.jellygom.miband_sdk.MiBandIO.Listener;


public class NotifyListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.jellygom.miband_sdk.MiBandIO.Listener.NotifyListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onNotify:([B)V:GetOnNotify_arrayBHandler:Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListenerInvoker, MiBandSDK\n" +
			"";
		mono.android.Runtime.register ("Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListenerImplementor, MiBandSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NotifyListenerImplementor.class, __md_methods);
	}


	public NotifyListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NotifyListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Jellygom.Miband_sdk.MiBandIO.Listener.INotifyListenerImplementor, MiBandSDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onNotify (byte[] p0)
	{
		n_onNotify (p0);
	}

	private native void n_onNotify (byte[] p0);

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
