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
            string name = GetUserInput("Please enter your name:");
            string otherGuest = GetUserInput("Do you want to add another name? (yes or no)").ToLower();

            do
            {
                GetUserInfo(name);

                raffleNumber = GenerateRandomNumber();
                guests.Add(raffleNumber, name);

                GetUserInfo(otherGuest);

                if (otherGuest == "no")
                    break;

                else continue;



            }
            while (otherGuest == "yes");

           
            foreach (var nameAndNum in guests)
            {
               Console.WriteLine($"{nameAndNum.Key} : {nameAndNum.Value}");
            }

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
