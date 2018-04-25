using System;

namespace CapStone
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMainMenu();

        }

        static void DisplayHeader(string header)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + header);
            Console.WriteLine();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayOpeningScreen()
        {
            Console.WriteLine();
            Console.WriteLine("\t Welcome to all");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static void DisplayMainMenu()
        {
            string menuChoice;
            bool loopRunning = true;


            while (loopRunning)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine();

                Console.WriteLine("\t1) Start Game");
                Console.WriteLine("\t2) ");
                Console.WriteLine("\t3) ");
                Console.WriteLine("\t4) Credits");
                Console.WriteLine("\tE) Exit");
                Console.WriteLine();
                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        GameStart();
                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "e":
                    case "E":
                        loopRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid response.");
                        break;
                }
            }
        }

        static void DisplayLoserScreen()
        {
            DisplayHeader("YOU LOSE");
            Console.WriteLine();
            Console.WriteLine("You cannon handle my game!");

        }

        static void GameStart()
        {
            while (true)
            {
                DisplayHeader("Welcome to Scene One:");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("The Tunnle");
                Console.WriteLine();
                Console.WriteLine("You awaken at the mouth of a long and dark tunnel");
            }

        }
    }

}