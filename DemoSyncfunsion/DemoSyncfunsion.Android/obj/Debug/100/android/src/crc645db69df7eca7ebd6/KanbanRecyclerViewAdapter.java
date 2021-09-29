package crc645db69df7eca7ebd6;


public class KanbanRecyclerViewAdapter
	extends androidx.recyclerview.widget.RecyclerView.Adapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItemCount:()I:GetGetItemCountHandler\n" +
			"n_getItemViewType:(I)I:GetGetItemViewType_IHandler\n" +
			"n_onCreateViewHolder:(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;:GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"n_onBindViewHolder:(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V:GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfKanban.Android.KanbanRecyclerViewAdapter, Syncfusion.SfKanban.XForms.Android", KanbanRecyclerViewAdapter.class, __md_methods);
	}


	public KanbanRecyclerViewAdapter ()
	{
		super ();
		if (getClass () == KanbanRecyclerViewAdapter.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfKanban.Android.KanbanRecyclerViewAdapter, Syncfusion.SfKanban.XForms.Android", "", this, new java.lang.Object[] {  });
	}

	public KanbanRecyclerViewAdapter (crc645db69df7eca7ebd6.SfKanban p0, crc645db69df7eca7ebd6.KanbanColumn p1)
	{
		super ();
		if (getClass () == KanbanRecyclerViewAdapter.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfKanban.Android.KanbanRecyclerViewAdapter, Syncfusion.SfKanban.XForms.Android", "Syncfusion.SfKanban.Android.SfKanban, Syncfusion.SfKanban.XForms.Android:Syncfusion.SfKanban.Android.KanbanColumn, Syncfusion.SfKanban.XForms.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public int getItemCount ()
	{
		return n_getItemCount ();
	}

	private native int n_getItemCount ();


	public int getItemViewType (int p0)
	{
		return n_getItemViewType (p0);
	}

	private native int n_getItemViewType (int p0);


	public androidx.recyclerview.widget.RecyclerView.ViewHolder onCreateViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateViewHolder (p0, p1);
	}

	private native androidx.recyclerview.widget.RecyclerView.ViewHolder n_onCreateViewHolder (android.view.ViewGroup p0, int p1);


	public void onBindViewHolder (androidx.recyclerview.widget.RecyclerView.ViewHolder p0, int p1)
	{
		n_onBindViewHolder (p0, p1);
	}

	private native void n_onBindViewHolder (androidx.recyclerview.widget.RecyclerView.ViewHolder p0, int p1);

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
