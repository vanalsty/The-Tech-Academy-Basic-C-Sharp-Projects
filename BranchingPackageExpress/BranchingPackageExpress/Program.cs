using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingPackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            string packageWeight;
            Console.WriteLine("Please enter the weight of your package.");
            packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight);
            if (weight <= 50)
            {
                Console.WriteLine("Please enter the width of your package.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the height of your package.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the length of your package.");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int totalDimension = packageWidth + packageLength + packageHeight;
                if (totalDimension <= 50)
                {
                    decimal shipCost = (packageWidth * packageLength * packageHeight * weight) /100m;
                    string shipCostString = shipCost.ToString("C2");
                    Console.WriteLine("Your estimated total for shipping this package is: " + shipCostString);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Package too big to by shipped via Package Express.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day!");
            }
          

        }
    }
}
