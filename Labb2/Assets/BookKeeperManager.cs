using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace Labb2
{
	public class BookKeeperManager
	{
		private static BookKeeperManager instance;
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		SQLiteConnection db;

		private BookKeeperManager()
		{
			
			db = new SQLiteConnection(path + @"\database.db");
			db.CreateTable<Entry>();
			db.CreateTable<TaxRate>();
			db.CreateTable<Account>();



			if (!db.Table<Account>().Any())
			{
				db.Insert(new Account { accountNr = 1010, name = "Försäljning", type = "Inkomst" });
				db.Insert(new Account { accountNr = 2020, name = "Lottovinst", type = "Inkomst" });

				db.Insert(new Account { accountNr = 3030, name = "Material", type = "Utgift" });
				db.Insert(new Account { accountNr = 4040, name = "Hyra", type = "Utgift" });

				db.Insert(new Account { accountNr = 5050, name = "Sparkonto", type = "Money" });
				db.Insert(new Account { accountNr = 6060, name = "Kapitalkonto", type = "Money" });

				db.Insert(new TaxRate {tax = 0.06});
				db.Insert(new TaxRate {tax = 0.12});
				db.Insert(new TaxRate {tax = 0.25});
			}



		}

		public static BookKeeperManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new BookKeeperManager();
				}
				return instance;
			}
		}

		public void AddEntry(Entry e1)
		{
			db.Insert(e1);
		}

		public List<Account> getTypeAccounts(string type)
		{
			var typeAccounts = db.Table<Account>().Where(a => a.type.Equals(type));
			return typeAccounts.ToList();
		}

		public List<TaxRate> getTaxRates()
		{
			return db.Table<TaxRate>().ToList();
		}

		public List<Account> getAccounts(string account)
		{
			var accounts = db.Table<Account>().Where(a => a.type.Equals(account));
			return accounts.ToList();
		}

		public List<Entry> getEntries()
		{
			return db.Table<Entry>().ToList();
		}

		public string getTaxReport()
		{
			var taxReport = getEntries().Select(e => string.Format(e.date + "\n"
			                                                       + e.type + ": " 
			                                                       + e.description 
			                                                       + "\n"
			                                                       + "Belopp: " 
			                                                       + e.total + "kr" + " \nmoms: " 
			                                                       + (e.isIncome ? (e.total * e.tax) 
			                                                          : (e.total * e.tax) * -1) 
			                                                       + "kr" + "\n*****************************"));

			return string.Join("\n", taxReport);
		}
	}
}