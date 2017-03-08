
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
	[Activity(Label = "CreateReportsActivity")]
	public class CreateReportsActivity : Activity
	{
		TextView taxReport;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.CreateReports);

			taxReport = FindViewById<TextView>(Resource.Id.taxReport);
			taxReport.Text = BookKeeperManager.Instance.getTaxReport();
		}
	}
}
