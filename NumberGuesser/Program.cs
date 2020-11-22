using System;

// Namespace 
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        
        // Entry Point Method
        static void Main(string[] args)
        {

            // Set app vars
            string appName = "Number Guesser"; 
            string appVersion = "1.0.0";
            string appAuthor = "Lyle Timotheus";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;


            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion,appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask Users Name
            Console.WriteLine("What is your name?");

            // Get user input
            string input = Console.ReadLine();

            // Give them a message
            Console.WriteLine("Hello {0}, lets play a game",input);
        }
    }
}
