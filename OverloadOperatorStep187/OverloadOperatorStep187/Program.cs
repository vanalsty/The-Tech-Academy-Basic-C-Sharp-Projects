using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorStep187
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.FirstName = "Sample";
            emp1.LastName = "Student";
            emp1.ID = 1;

            Employee emp2 = new Employee();
            emp2.FirstName = "Jane";
            emp2.LastName = "Doe";
            emp2.ID = 2;

            emp1.SayName();
            Console.ReadLine();

        }
            
        
    }
}
