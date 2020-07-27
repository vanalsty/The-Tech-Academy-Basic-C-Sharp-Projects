using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStep165
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chose a second number. Press return if you do not want a second number:");
            string answer = Console.ReadLine();

            MathOps FirstOp = new MathOps();

            Console.WriteLine("Your number(s) + 10 = " + FirstOp.MathMethod(num1, answer));

            Console.ReadLine();

        }
    }
}
