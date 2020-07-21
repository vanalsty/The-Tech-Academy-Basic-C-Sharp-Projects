using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \nPerson 1");
            
            string hourRate1;
            string hoursWorked1;
            Console.WriteLine("Hourly Rate?");
            hourRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            hoursWorked1 = Console.ReadLine();

            Console.WriteLine("Person 2");
            string hourRate2;
            string hoursWorked2;
            Console.WriteLine("Hourly Rate?");
            hourRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            hoursWorked2 = Console.ReadLine();


            double annualSal1;
            Console.WriteLine("Annual salary of Person 1");
            double hourlyRate1 = Convert.ToDouble(hourRate1);
            double numHours1 = Convert.ToDouble(hoursWorked1);
            annualSal1 = hourlyRate1 * numHours1 * 52;
            Console.WriteLine(annualSal1);
            Console.ReadLine();


            double annualSal2;
            Console.WriteLine("Annual salary of Person 2");
            double hourlyRate2 = Convert.ToDouble(hourRate2);
            double numHours2 = Convert.ToDouble(hoursWorked2);
            annualSal2 = hourlyRate2 * numHours2 * 52;
            Console.WriteLine(annualSal2);
            Console.ReadLine();


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (annualSal1 > annualSal2)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }

        }
    }
}
