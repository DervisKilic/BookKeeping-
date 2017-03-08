
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Labb2
{
	[Activity(Label = "EntryListActivity")]
	public class EntryListActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.EntryList);

			ListView l1 = FindViewById<ListView>(Resource.Id.entryList);

			BookKeeperManager b1 = BookKeeperManager.Instance;
			EntryListAdapter eLA = new EntryListAdapter(this,b1.getEntries());

			l1.Adapter = eLA;

		}
	}

	public class EntryListAdapter : BaseAdapter<Entry>
	{
		List<Entry> items;
		Activity context;
		public EntryListAdapter(Activity context, List<Entry> items)
			: base()
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override Entry this[int position]
		{
			get { return items[position]; }
		}
		public override int Count
		{
			get { return items.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent)
		{

			var item = items[position];
			View view = convertView;

			if (view == null)
				view = context.LayoutInflater.Inflate(Resource.Layout.Custom_row, null);
			view.FindViewById<TextView>(Resource.Id.dateTV).Text = item.date;
			view.FindViewById<TextView>(Resource.Id.descTV).Text = item.description;

			if (item.isExpense)
			{
				view.FindViewById<TextView>(Resource.Id.priceTV).Text = "-" + item.total.ToString() + "kr";
			}
			else
			{
				view.FindViewById<TextView>(Resource.Id.priceTV).Text = item.total.ToString() + "kr";
			}

			return view;
		}
	}
}