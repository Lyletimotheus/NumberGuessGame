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
            // Run GetAppInfo() to get the app information
            GetAppInfo();

            // Ask for the User Name and say Hello
            GreetUser();
            

            while (true)
            {

                // Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //Write a loop, while guess is not correct
                while (guess != correctNumber)
                {
                    //Guess users input
                    string input = Console.ReadLine();

                    // Make sure it is a number 
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red,"Please enter an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct Number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number Please Try Again!");

                    }
                }
                
                // Success message 
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");


                // Ask to play the game again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }else
                {
                    return;
                }

            }
        }   
        // Get and display the app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Lyle Timotheus";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;


            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
        // Ask the users name and greets them
        static void GreetUser()
        {
            // Ask Users Name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();


            // Give them a message
            Console.WriteLine("Hello {0}, lets play a game", inputName);
        }

        // Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;


            // Tell the user it is the wrong number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
