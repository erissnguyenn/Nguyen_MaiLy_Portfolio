using System;

namespace NguyenMaiLy_Assignment05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * Mai Ly Nguyen
			 * March 24, 2016
			 * Project and Portfolio I: Development
			 * Assignment 05: Building a Code Repository
			 * 
			 * DESCRIPTION: BLAH BLAH
			 */

			Console.WriteLine ("===================================================================");
			Console.WriteLine ("                            Swap Name                              ");
			Console.WriteLine ("===================================================================");

			// Prompt user for first name
			Console.Write ("Please enter in your FIRST name: ");
			// Get input for first name
			string firstName_Str = Console.ReadLine ();

			// Prompt user for last name
			Console.Write ("Please enter in your LAST name: ");
			// Get input for last name
			string lastName_Str = Console.ReadLine ();

			// Call function SwapName()
			SwapName (firstName_Str, lastName_Str);
		}

		// FUNCTIONS ---------------------------------------------------------------------------------

		// Exercise 1: Swap Name
		public static string SwapName(string firstName, string lastName){
			Console.WriteLine ("\r\nYour FIRST and LAST name: " + firstName + " " + lastName);
			Console.WriteLine ("Your SWAPPED FIRST name: " + lastName);
			Console.WriteLine ("Your SWAPPED LAST name: " + firstName);

			return null;
		}
	}
}
