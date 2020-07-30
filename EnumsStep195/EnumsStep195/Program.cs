using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsStep195
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day of the week: ");

            try
            {
                DaysOfTheWeek daySelect = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                foreach (string day in Enum.GetNames(typeof(DaysOfTheWeek)))
                {
                    Console.WriteLine("{0} = {1:D}", day, Enum.Parse(typeof(DaysOfTheWeek), day));

                }
                Console.WriteLine("You entered: " + "{0} = {1:D}", daySelect, Enum.Parse(typeof(DaysOfTheWeek), daySelect.ToString()));
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week: ");
            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
    }

