
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
	[Activity(Label = "NewEntryActivity")]
	public class NewEntryActivity : Activity
	{
		BookKeeperManager b1 = BookKeeperManager.Instance;
		Entry e1 = new Entry();

		Button addEntry;
		RadioButton incRB;
		RadioButton expRB;
		DatePicker date;
		EditText description;
		EditText total;
		Spinner typeSpinner;
		Spinner taxSpinner;
		Spinner accountSpinner;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.NewEntry);

			addEntry = FindViewById<Button>(Resource.Id.addEntryButton);
			incRB = FindViewById<RadioButton>(Resource.Id.incRB);
			expRB = FindViewById<RadioButton>(Resource.Id.expRB);
			date = FindViewById<DatePicker>(Resource.Id.datePicker);
			description = FindViewById<EditText>(Resource.Id.descriptionET);
			total = FindViewById<EditText>(Resource.Id.totalET);
			typeSpinner = FindViewById<Spinner>(Resource.Id.typeSpinner);
			taxSpinner = FindViewById<Spinner>(Resource.Id.taxSpinner);
			accountSpinner = FindViewById<Spinner>(Resource.Id.accountSpinner);

			addEntry.Click += delegate
			{
				if (incRB.Checked)
				{
					e1.type = "Inkomst";
					e1.isIncome = true;
					e1.isExpense = false;
				}
				else
				{
					e1.type = "Utgift";
					e1.isIncome = false;
					e1.isExpense = true;
				}

				e1.date = date.DateTime.ToString("yyyy-MM-dd");
				e1.description = description.Text;
				e1.total = Double.Parse(total.Text);
				e1.tax = ((TaxRate)taxSpinner.SelectedItem).tax;
				e1.account = ((Account)accountSpinner.SelectedItem).accountNr;
				b1.AddEntry(e1);
			};

			getType();
			getTaxRates();
			getAccounts();
		}
		public void getType()
		{
			incRB.Click += delegate
			{
				typeSpinner.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1,
															   BookKeeperManager.Instance.getAccounts("Inkomst"));
			};

			expRB.Click += delegate
			{
				typeSpinner.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1,
															   BookKeeperManager.Instance.getAccounts("Utgift"));
			};
		}
		public void getTaxRates()
		{
			taxSpinner.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1,
			                                       BookKeeperManager.Instance.getTaxRates());
		}

		public void getAccounts()
		{
			accountSpinner.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1,
															   BookKeeperManager.Instance.getAccounts("Money"));
		}
	}
}
