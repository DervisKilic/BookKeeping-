package md5519c80ec60ab1529bce469143fb0f310;


public class NewEntryActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Labb2.NewEntryActivity, Labb2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NewEntryActivity.class, __md_methods);
	}


	public NewEntryActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NewEntryActivity.class)
			mono.android.TypeManager.Activate ("Labb2.NewEntryActivity, Labb2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
