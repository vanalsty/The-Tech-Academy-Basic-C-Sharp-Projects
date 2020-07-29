using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorStep187
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
            {
                Console.WriteLine("The two employees do not have the same ID.");
                return true;
            }

            else
            {
                Console.WriteLine("The two employees have the same ID.");
                return false;
            }
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                Console.WriteLine("The two employees have the same ID.");
                return true;
            }

            else
            {
                Console.WriteLine("The two employees do not have the same ID.");
                return false;
            }
        }
    }
}
