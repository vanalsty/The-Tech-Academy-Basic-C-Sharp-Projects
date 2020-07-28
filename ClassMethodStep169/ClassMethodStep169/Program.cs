using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStep169
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to divide by two:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Class1 numbers = new Class1();
            numbers.DivideByTwo(userNum);
            Console.ReadLine();



            int myNum1 = Class2.PlusMethod(8, 5);
            double myNum2 = Class2.PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
            Console.ReadLine();

        }
    }
}
