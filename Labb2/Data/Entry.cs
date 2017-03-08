using System;
using SQLite;

namespace Labb2
{
	
	public class Entry: Java.Lang.Object
	{

		[PrimaryKey, AutoIncrement]

		public int Id { get; private set; }
		public String date { get; set; }
		public String description { get; set; }
		public double total { get; set; }
		public double tax { get; set; }
		public int account { get; set; }
		public bool isIncome { get; set; }
		public bool isExpense { get; set; }
		public String type { get; set; }
	}
}
