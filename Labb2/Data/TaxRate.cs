using System;
using System.Collections.Generic;
using SQLite;

namespace Labb2
{
	public class TaxRate: Java.Lang.Object
	{
		[PrimaryKey, AutoIncrement]
		public int id { get; private set; }
		public double tax { get; set; }
		/*
		 * Vilka procentsatser för moms som kan väljas i spinner-menyer av användaren.
		 * Är väldigt enkel, innehåller bara ett decimaltal som avser procentsatsen.
		 * Skapas inte av användaren, utan är fördefinierade.
		 */

		public override string ToString()
		{
			return string.Format(tax * 100 + "%");
		}
	}

}
