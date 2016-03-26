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

					// Prompt user for sentence
					Console.WriteLine ("Please enter a sentence that has at least SIX words in it: ");
					// Get input for sentence
					string sentence_Str = Console.ReadLine ();

					// Call function Backwards()
					Backwards (sentence_Str);
					
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

		// Exercise 1: SwapName ----------------------------------------------------------------------
		public static string SwapName(string firstName, string lastName){

			Console.WriteLine ("\r\nYour FIRST and LAST name: " + firstName + " " + lastName);
			Console.WriteLine ("Your SWAPPED FIRST name: " + lastName);
			Console.WriteLine ("Your SWAPPED LAST name: " + firstName);

			return null;
		}

		// Exercise 2: Backwards ---------------------------------------------------------------------
		public static string Backwards(string sentence){

			// Create array and split sentence according to each space between each word
			string[] array = sentence.Split (' ');

			// Testing number of words in sentenced typed:
			// Console.Write (array.Length);

			// Loop error message until user enters a minimum of 6 words in their sentence
			while (true) {
				if (array.Length >= 6) {
					// Output each word in the sentence as an array
					Console.WriteLine ("\r\nThe sentence you entered: ");
					foreach (string word in array) {
						Console.Write (word + " ");
					}

					// Reverse the order of each word in the sentence by reversing the array
					Array.Reverse (array);
					// Output each word in the sentence as an array in REVERSE
					Console.WriteLine ("\r\n\r\nThe sentence you entered in REVERSE: ");
					foreach (string word in array) {
						// Remove any punctuations in reversed output
						Console.Write (word.Trim ('.').Trim ('!').Trim ('?') + " ");
					}
					break;

				} else {
					// Error message when user enters less than 6 words
					// Reprompt user for minimum 6 word sentence
					Console.WriteLine ("\r\n!! ERROR !! INVALID ENTRY !! \r\n--> Please enter a minimum of SIX words in your sentence:");
					sentence = Console.ReadLine();
					array = sentence.Split (' ');
					// Console.WriteLine (array.Length);
				}
			}

			return null;
		}

		// Exercise 3: AgeConvert ---------------------------------------------------------------------
	}
}
