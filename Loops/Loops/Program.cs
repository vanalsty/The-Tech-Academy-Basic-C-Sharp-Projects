using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you think you'll need to press enter until this while loop ends? \nIt's less than 100!  haha!");     
            {
                int i = 0;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                    i++;
                }

                Console.WriteLine("Now that wasn't too bad, was it?"); 
                Console.WriteLine("Press Enter Key continue to the do while statement.");
                Console.ReadLine();


                Console.WriteLine("What letter does my first name start with? (Please type capital letter)");
                string fName = Console.ReadLine();

                bool isGuess = fName == "L";

                do
                {
                    switch (fName)
                    {
                        case "J":
                            Console.WriteLine("You're very warm!!  Keep guessing!");
                            fName = Console.ReadLine();
                            break;
                        case "N":
                            Console.WriteLine("You're very warm!!  Keep guessing!");
                            fName = Console.ReadLine();
                            break;
                        case "K":
                            Console.WriteLine("Oh you are sooooo close!!  Keep guessing!");
                            fName = Console.ReadLine();
                            break;
                        case "M":
                            Console.WriteLine("Oh you are sooooo close!!  Keep guessing!");
                            fName = Console.ReadLine();
                            break;
                        case "L":
                            Console.WriteLine("Ding! Ding! Ding!  You are the winner! \nThanks for playing!");
                            isGuess = true;
                            break;
                        default:
                            Console.WriteLine("You are way off!  Try again");
                            fName = Console.ReadLine();
                            break;
                    }
                }
                while (!isGuess);

                Console.Read();

            }

            
        }
    }
}
