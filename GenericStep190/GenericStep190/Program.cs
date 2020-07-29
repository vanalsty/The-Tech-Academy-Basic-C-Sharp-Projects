using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStep190
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> employeesStr = new Employee<string>();
            employeesStr.things = new List<string>();
            employeesStr.things.Add("Jack McFarland");
            employeesStr.things.Add("Grace Adler");
            employeesStr.things.Add("Will Truman");
            employeesStr.things.Add("Karen Walker");


            Employee<int> employeesInt = new Employee<int>();
            employeesInt.things = new List<int>();
            employeesInt.things.Add(1234);
            employeesInt.things.Add(1235);
            employeesInt.things.Add(1236);
            employeesInt.things.Add(1237);


            foreach (var str in employeesStr.things)
                Console.WriteLine("{0}", str);

            
            foreach (int integer in employeesInt.things)
                Console.WriteLine("{0}", integer);

            Console.ReadLine();
        }
    }
}
