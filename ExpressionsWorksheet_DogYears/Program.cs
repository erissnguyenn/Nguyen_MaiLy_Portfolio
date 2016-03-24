using System;

namespace ExpressionsWorksheet_DogYears
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 
			 * Mai Ly Nguyen
			 * December 3, 2015
			 * SDI Section 01
			 * Expressions Worksheet
			 */

			// Dog Years

			// Prompt user and collect user input
			Console.WriteLine ("Dog Years Calculator");

			Console.Write ("\r\n\r\nHow old is your dog in HUMAN years?: ");
			string humanAge_Str = Console.ReadLine ();
			uint humanAge_Num = uint.Parse (humanAge_Str);

			// Calculate human years to dog years
			// dog age = 7 * human age
			uint dogAge = 7 * humanAge_Num;

			// End Results
			Console.WriteLine ("\r\nYour dog is " + humanAge_Num + " human years old," +
							   "\r\nwhich is " + dogAge + " in dog years.");


		}
	}
}
