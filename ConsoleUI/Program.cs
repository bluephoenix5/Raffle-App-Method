using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        //Get user name, generate rdm num, add to dictionary
        //How to ask if another name needs to be added
        //Get other users name, generate rdm num, add to dictionary


        public static Dictionary<int, string> guests = new Dictionary<int, string>();
        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();
        

        public static int GenerateRandomNumber(int min = 1000, int max = 9999)
        {
            return _rdm.Next(min, max);
        }

        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }

        static string GetUserInfo()
        {
            string name = null;
            string otherGuest;

            do
            {
                name = GetUserInput("Please enter your name:");
                
                raffleNumber = GenerateRandomNumber(min, max);

                guests.Add(raffleNumber, name);

                otherGuest = GetUserInput("Do you want to add another name (yes or no)?").ToLower();
            }

            while (otherGuest == "yes");

            foreach (var kvp in guests)
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value}\n");
                
            }

            Random winner = new Random();
            int index = winner.Next(guests.Count);
            KeyValuePair<int, string> pair = guests.ElementAt(index);

            Console.WriteLine("The winner is: " + pair.Value + "!!!");

            return Console.ReadLine();

                        
        }

        
            
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Raffle!");
            GetUserInfo();
            //MultiLineAnimation();
        }

        //Start writing your code here

       

        
        




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
