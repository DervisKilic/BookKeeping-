using Android.App;
using Android.OS;
using Android.Content;
using Android.Widget;

namespace Labb2
{
	[Activity(Label = "Labb2", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			Button newEntryButton = FindViewById<Button>(Resource.Id.newEvent);
			Button showEntriesButton = FindViewById<Button>(Resource.Id.showAllEvents);
			Button createReports= FindViewById<Button>(Resource.Id.createReports);


			newEntryButton.Click += delegate {
				var intent = new Intent(this, typeof(NewEntryActivity));
				StartActivity(intent);
			};

			showEntriesButton.Click += delegate
			{
				var intent = new Intent(this, typeof(EntryListActivity));
				StartActivity(intent);
			};

			createReports.Click += delegate
			{
				var intent = new Intent(this, typeof(CreateReportsActivity));
				StartActivity(intent);
			};
		}
	}
}

