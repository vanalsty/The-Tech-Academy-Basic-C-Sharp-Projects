using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStep166
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mathObject = new Class1();
            Console.WriteLine("Enter an integer: ");
            string userInput = Console.ReadLine();
            int int1 = Convert.ToInt32(userInput);
            Console.WriteLine("Enter a different integer: ");
            string userInput2 = Console.ReadLine();
            int int2 = Convert.ToInt32(userInput2);

            mathObject.MyMethod(int1, int2);
            Console.ReadLine();
        }
    }
}
