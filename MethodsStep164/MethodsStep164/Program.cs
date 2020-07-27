using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsStep164
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be multiplied by 2:");
            string myInt = Console.ReadLine();
            int y = Convert.ToInt32(myInt);
            Console.WriteLine(MathClass.Multiply(2, y));
            Console.ReadLine();


            Console.WriteLine("Enter a decimal number and 2 will be added to it and an integer returned: ");
            string input = Console.ReadLine();
            decimal userDec = Convert.ToDecimal(input);
            Console.WriteLine(MathClass.Add(userDec, 2));
            Console.ReadLine();

            Console.WriteLine("Enter a number to be divided by 10");
            string userString = Console.ReadLine();
            int userInt = Convert.ToInt32(userString);
            Console.WriteLine(MathClass.Divide(userInt, 10));
            Console.ReadLine();
        }
    }
}
