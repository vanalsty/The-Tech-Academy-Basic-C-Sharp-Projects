using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeStep222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            DateTime current = DateTime.Now;
            var future = current.AddHours(num);

            Console.WriteLine("It will be " + future + " in " + num + " hours");
            Console.ReadLine();
        }
    }
}
