using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorsStep88
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input from user multiply by 50
            string num1;
            int output1;
            Console.WriteLine("Enter a number and it will be multiplied by 50");
            num1 = Console.ReadLine();
            int answer1 = Convert.ToInt32(num1);
            output1 = answer1 * 50;
            Console.WriteLine("Your number times 50 is: " + output1);
            Console.ReadLine();

            //Input from user plus 25
            string num2;
            int output2;
            Console.WriteLine("Enter a number and 25 will be added to it.");
            num2 = Console.ReadLine();
            int answer2 = Convert.ToInt32(num2);
            output2 = answer2 + 25;
            Console.WriteLine("Your number plus 25 is: " + output2);
            Console.ReadLine();

            //Input from user divided by 12.5
            string num3;
            double output3;
            Console.WriteLine("Enter a number and it will be divided by 12.5.");
            num3 = Console.ReadLine();
            double answer3 = Convert.ToInt32(num3);
            output3 = answer3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + output3);
            Console.ReadLine();

            //Input from user check if > 50
            string num4;
            Console.WriteLine("Enter a number to find out if it is greater than 50.");
            num4 = Console.ReadLine();
            double convertNum4 = Convert.ToDouble(num4);

            if (convertNum4 > 50) 
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }

            //Input from user divided by 7, print remainder.
            string num5;
            double output5;
            Console.WriteLine("Enter a number and find out what the remainder is when it\'s divided by 7.");
            num5 = Console.ReadLine();
            double answer5 = Convert.ToInt32(num5);
            output5 = answer5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + output5);
            Console.ReadLine();

        }
    }
}
