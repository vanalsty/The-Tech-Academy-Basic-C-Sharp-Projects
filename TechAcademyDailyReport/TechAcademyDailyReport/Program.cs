using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \r\nStudent Daily Report");
            
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            int coursePageNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\".");
            bool CourseHelp= Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics.");
            string Positive = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string Feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();

        }
    }
}
