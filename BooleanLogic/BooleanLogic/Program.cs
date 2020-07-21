using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            string Age;
            Console.WriteLine("What is your age?");
            Age = Console.ReadLine();
            int age = Convert.ToInt32(Age);

            string DUI;
            Console.WriteLine("Have you ever had a DUI?  Please answer \"yes\" or \"no\".");
            DUI = Console.ReadLine();

            string Tickets;
            Console.WriteLine("How many speeding tickets do you have?");
            Tickets = Console.ReadLine();
            int speedTickets = Convert.ToInt32(Tickets);

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && DUI == "no" && speedTickets <= 3);
            Console.ReadLine();
        }
    }
}
