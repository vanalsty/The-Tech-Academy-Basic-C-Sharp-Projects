using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStep182
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee()
            {
                firstName = " Sample",
                lastName = " Student",
            };
            name.SayName();
            Console.ReadLine();

            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
