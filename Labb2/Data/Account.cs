using System;
using SQLite;
namespace Labb2
{
	public class Account: Java.Lang.Object
	{
		[PrimaryKey]
		public int accountNr { get; set;}
		public String name { get; set;}
		public String type { get; set; }
		/*
		 * Ett konto som kan väljas i spinner-menyer av användaren.Är väldigt enkel, 
		 * innehåller bara ett namn och ett nummer.Skapas inte av användaren, utan är fördefinierade.
		*/

		public override string ToString()
		{
			return string.Format(accountNr + "(" + name + ")");
		}
	}
}
