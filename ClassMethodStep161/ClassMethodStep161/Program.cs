using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStep161
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a number and the program will perform 4 math operations on that number.");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num + " + 2 = " + MathOperation.Add(num));
                Console.WriteLine(num + " x 2 = " + MathOperation.Mult(num));
                Console.WriteLine(num + " - 2 = " + MathOperation.Subtract(num));
                Console.WriteLine(num + " / 2 = " + MathOperation.Divide(num));
                Console.ReadLine();

            }
        }
    }
}
