using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaStep203
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>{ //Create list of 10 employees.  2 with first name Joe.
            new Employees{ FirstName = "Joe", LastName = "Dirt", ID = 1 },
            new Employees{ FirstName = "Reba", LastName = "McEntire", ID = 2 },
            new Employees{ FirstName = "Snoop", LastName = "Dogg", ID = 3 },
            new Employees{ FirstName = "Justin", LastName = "Bieber", ID = 4 },
            new Employees{ FirstName = "Brittney", LastName = "Spears", ID = 5 },
            new Employees{ FirstName = "Michael", LastName = "Jordan", ID = 6 },
            new Employees{ FirstName = "Tim", LastName = "Taylor", ID = 7 },
            new Employees{ FirstName = "Tiger", LastName = "Woods", ID = 8 },
            new Employees{ FirstName = "Joe", LastName = "Schmoe", ID = 9 },
            new Employees{ FirstName = "Rose", LastName = "Nylund", ID = 10 },
        };

            List<Employees> JoeList = new List<Employees>();
            foreach (Employees employee in employees) //use foreach loop to create new list of employees with first name Joe
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }
            
            List<Employees> Joes = new List<Employees>(); //use foreach loop to create new list of employees with first name Joe using lambda expression
            Joes = employees.FindAll(x => x.FirstName == "Joe").ToList();
            foreach (Employees joeLambda in Joes)
            {
                Console.WriteLine(joeLambda.FirstName + " " + joeLambda.LastName);
            }

            List<Employees> IDnum = new List<Employees>(); //using lambda expression make list of all employes with ID greater than 5
            IDnum = employees.FindAll(i => i.ID > 5).ToList();
            foreach (Employees id in IDnum )
            {
                Console.WriteLine(id.FirstName + " " + id.LastName + " ID: " + id.ID);
            }
            Console.ReadLine();

        }
    }
}
