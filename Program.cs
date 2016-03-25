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
			Console.WriteLine ("                               MENU                                ");
			Console.WriteLine ("===================================================================");

			Console.WriteLine ("Please choose a program:");
			Console.WriteLine ("  A. Swap Name");
			Console.WriteLine ("  B. Backwards");
			Console.WriteLine ("  C. AgeConvert");
			Console.WriteLine ("  D. TempConvert");
			Console.Write ("Please enter only A, B, C, or D: ");
			string response = Console.ReadLine ();
			// Check to see if user entered anything;
			// If user leave blank, output error message and prompt again.
			while (string.IsNullOrWhiteSpace (response)) {
				Console.Write ("\r\n!! ERROR !! PLEASE DO NOT LEAVE THIS PART BLANK !!\r\n--> Please enter in your response using only A, B, C or D: ");
				response = Console.ReadLine ();
			}

			while (true) {
				if (response == "A" || response == "a") {

					Console.WriteLine ("===================================================================");
					Console.WriteLine ("                       Exercise 1: SwapName                        ");
					Console.WriteLine ("===================================================================");

					// Prompt user for FIRST NAME
					Console.Write ("Please enter in your FIRST name: ");
					// Get input for first name
					string firstName_Str = Console.ReadLine ();
					// Check to see if user entered anything;
					// If user leave blank, output error message and prompt again.
					while (string.IsNullOrWhiteSpace (firstName_Str)) {
						Console.Write ("\r\n!! ERROR !! PLEASE DO NOT LEAVE THIS PART BLANK !!\r\n--> Please enter in your FIRST name: ");
						firstName_Str = Console.ReadLine ();
					}

					// Prompt user for LAST NAME
					Console.Write ("\r\nPlease enter in your LAST name: ");
					// Get input for last name
					string lastName_Str = Console.ReadLine ();
					// Check to see if user entered anything;
					// If user leave blank, output error message and prompt again.
					while (string.IsNullOrWhiteSpace (lastName_Str)) {
						Console.Write ("\r\n!! ERROR !! PLEASE DO NOT LEAVE THIS PART BLANK !!\r\n--> Please enter in your LAST name: ");
						lastName_Str = Console.ReadLine ();
					}

					// Call function SwapName()
					SwapName (firstName_Str, lastName_Str);

					break; 

				} else if (response == "B" || response == "b") {
					Console.WriteLine ("===================================================================");
					Console.WriteLine ("                       Exercise 2: Backwards                       ");
					Console.WriteLine ("===================================================================");

					Console.WriteLine ("Please enter a sentence that has at least SIX words in it: ");
					string sentence_Str = Console.ReadLine ();

					Console.WriteLine ("The sentence you entered: " + sentence_Str);
					break;
				} else if (response == "C" || response == "c") {
					Console.WriteLine ("===================================================================");
					Console.WriteLine ("                       Exercise 3: AgeConvert                      ");
					Console.WriteLine ("===================================================================");
					break;
				} else if (response == "D" || response == "d") {
					Console.WriteLine ("===================================================================");
					Console.WriteLine ("                       Exercise 4: TempConvert                     ");
					Console.WriteLine ("===================================================================");
					break;
				} else {
					Console.Write ("\r\n!! ERROR !! INVALID ENTRY !!\r\n--> Please enter in your response using only A, B, C or D: ");
					response = Console.ReadLine ();
				}
			}


		}


		// FUNCTIONS ---------------------------------------------------------------------------------

		// Exercise 1: SwapName
		public static string SwapName(string firstName, string lastName){

			Console.WriteLine ("\r\nYour FIRST and LAST name: " + firstName + " " + lastName);
			Console.WriteLine ("Your SWAPPED FIRST name: " + lastName);
			Console.WriteLine ("Your SWAPPED LAST name: " + firstName);

			return null;
		}

		// Exercise 2: Backwards

	}
}
