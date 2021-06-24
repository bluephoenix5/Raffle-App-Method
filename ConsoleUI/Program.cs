using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Raffle!");
            GetUserInfo("");
        }

        //Start writing your code here

        private static Dictionary<int, string> guests = new Dictionary<int, string>();
        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();

        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static string GetUserInfo(string input)
        {
            //Get user name, generate rdm num, add to dictionary
            //How to ask if another name needs to be added
            //Get other users name, generate rdm num, add to dictionary

            do
            {
                GetUserInput("Please enter your name:");

                string name = Console.ReadLine();

                GenerateRandomNumber(min, max);

                guests.Add(raffleNumber, name);

                Console.WriteLine("Do you want to add another name (yes or no)?");
            }

            while (Console.ReadLine() == "yes");
            

            Console.WriteLine(guests.Count);

            return Console.ReadLine();
        }
        
        
        public static int GenerateRandomNumber(int min = 1000, int max = 9999)
        {
            return raffleNumber = _rdm.Next(min, max);
        }

        




        static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
        {
            var counter = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    │││ \\   ║");
                            Console.WriteLine("         ║    │││  O  ║");
                            Console.WriteLine("         ║    OOO     ║");
                            break;
                        };
                    case 1:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║   / │││    ║");
                            Console.WriteLine("         ║  O  │││    ║");
                            Console.WriteLine("         ║     OOO    ║");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("         ╔════╤╤╤╤════╗");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    ││││    ║");
                            Console.WriteLine("         ║    OOOO    ║");
                            break;
                        };
                }

                counter++;
                Thread.Sleep(200);
            }
        }
    }
}
