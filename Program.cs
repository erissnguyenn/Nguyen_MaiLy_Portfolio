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
			Console.Write ("\r\nPlease enter only A, B, C, or D: ");
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

					// Prompt user for name
					Console.Write ("Please enter in your NAME: ");
					// Get input for name
					string name_Str = Console.ReadLine ();
					// Check to see if user entered anything;
					// If user leave blank, output error message and prompt again.
					while (string.IsNullOrWhiteSpace (name_Str)) {
						Console.Write ("\r\n!! ERROR !! PLEASE DO NOT LEAVE THIS PART BLANK !!\r\n--> Please enter in your NAME: ");
						name_Str = Console.ReadLine ();
					}

					// Prompt user for age
					Console.Write ("\r\nPlease enter in your AGE: ");
					// Get input for age
					string age_Str = Console.ReadLine ();
					// Check to see if user entered anything;
					// If user leave blank, output error message and prompt again.
					while (string.IsNullOrWhiteSpace (age_Str)) {
						Console.Write ("\r\n!! ERROR !! PLEASE DO NOT LEAVE THIS PART BLANK !!\r\n--> Please enter in your AGE: ");
						age_Str = Console.ReadLine ();
					}
					// Check to see if input is a number, if not try again.
					int age = 0;

					while(!int.TryParse(age_Str, out age)){
						// Prompt user invalid entry and reprompt them for their age 
						Console.Write ("\r\n!! ERROR !! INVALID ENTRY !!\r\n--> Please enter your age: ");
						age_Str = Console.ReadLine();
					}

					// Call function AgeConvert()
					AgeConvert(name_Str, age);

					break;

				} else if (response == "D" || response == "d") {
					Console.WriteLine ("===================================================================");
					Console.WriteLine ("                       Exercise 4: TempConvert                     ");
					Console.WriteLine ("===================================================================");

					// Prompt user for temperature in Fahrenheit
					Console.Write ("Please enter in the temperature NUMBER in FAHRENHEIT: ");
					// Get input for temperature in Fahrenheit
					string fahrenheit_Str = Console.ReadLine ();
					// Check to see if user entered anything;
					// If user leave blank, output error message and prompt again.
					while (string.IsNullOrWhiteSpace (fahrenheit_Str)) {
						Console.Write ("\r\n!! ERROR !! PLEASE DO NOT LEAVE THIS PART BLANK !!\r\n--> Please enter in the temperature NUMBER in FAHRENHEIT: ");
						fahrenheit_Str = Console.ReadLine ();
					}
					// Check to see if input is a number, if not try again.
					double fahrenheit = 0;

					while(!double.TryParse(fahrenheit_Str, out fahrenheit)){
						// Prompt user invalid entry and reprompt them for the number in Fahrenheit
						Console.Write ("\r\n!! ERROR !! INVALID ENTRY !!\r\n--> Please enter in the temperature number in FAHRENHEIT: ");
						fahrenheit_Str = Console.ReadLine();
					}


					// Prompt user for temperature in Celsius
					Console.Write ("Please enter in the temperature NUMBER in CELSIUS: ");
					// Get input for temperature in Celsius
					string celsius_Str = Console.ReadLine ();
					// Check to see if user entered anything;
					// If user leave blank, output error message and prompt again.
					while (string.IsNullOrWhiteSpace (celsius_Str)) {
						Console.Write ("\r\n!! ERROR !! PLEASE DO NOT LEAVE THIS PART BLANK !!\r\n--> Please enter in the temperature NUMBER in CELSIUS: ");
						celsius_Str = Console.ReadLine ();
					}
					// Check to see if input is a number, if not try again.
					double celsius = 0;

					while(!double.TryParse(celsius_Str, out celsius)){
						// Prompt user invalid entry and reprompt them for the number in Celsius
						Console.Write ("\r\n!! ERROR !! INVALID ENTRY !!\r\n--> Please enter in the temperature number in CELSIUS: ");
						celsius_Str = Console.ReadLine();
					}

					// Call function TempConvert();
					TempConvert(fahrenheit, celsius);

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
		public static string AgeConvert (string name, int age){
			
			// Display user's name and age
			Console.WriteLine ("\r\n" + name + " is " + age + " years old.");

			// Calculate and display number of DAYS alive
			int daysAlive = 365 * age;
			Console.WriteLine ("\r\n" + name + " has been alive for " + daysAlive + " days.");

			// Calculate and display number of HOURS alive
			int hoursAlive = 8760 * age;
			Console.WriteLine (name + " has been alive for " + hoursAlive + " hours.");

			// Calculate and display number of MINUTES alive
			int minutesAlive = 525600 * age;
			Console.WriteLine (name + " has been alive for " + minutesAlive + " minutes.");

			// Calculate and display number of SECONDS alive
			int secondsAlive = 31536000 * age;
			Console.WriteLine (name + " has been alive for " + secondsAlive + " seconds.");

			return null;
		}

		// Exercise 4: TempConvert --------------------------------------------------------------------
		public static string TempConvert(double fahrenheit, double celsius){
			
			// Display the temperature the user entered in Fahrenheit
			Console.WriteLine ("\r\nYou entered " + fahrenheit + "°" + " Fahrenheit");
			// Calculate Fahrenheit to Celsius
			double celsiusValue = (fahrenheit - 32) * 5 / 9;
			// Display Fahrenheit to Celsius calculation results
			Console.WriteLine (fahrenheit + "° Fahrenheit --> " + Math.Round(celsiusValue, 2) + "° Celsius");

			// Display the temperature the user entered in Celsius
			Console.WriteLine ("\r\nYou entered " + celsius + "°" + " Celsius");
			// Calculate Celsius to Fahrenheit
			double fahrenheitValue = celsius * 9/5 + 32;
			// Display Celsius to Fahrenheit calculation results
			Console.WriteLine (celsius + "° Celsius --> " + Math.Round(fahrenheitValue, 2) + "° Fahrenheit");

			return null;
		}
	}
}
