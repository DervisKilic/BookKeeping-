package md5519c80ec60ab1529bce469143fb0f310;


public class Entry
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Labb2.Entry, Labb2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Entry.class, __md_methods);
	}


	public Entry () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Entry.class)
			mono.android.TypeManager.Activate ("Labb2.Entry, Labb2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
