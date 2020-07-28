using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStep182
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Today is my last day of work.  I quit!");
        }
    }
}
