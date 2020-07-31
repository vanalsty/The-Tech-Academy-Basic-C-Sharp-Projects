using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarStep230
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            const string showDogName = "Barbary Bow Chicka Wow Wow";
            Console.WriteLine("Show dogs have the craziest names!\r\nHere's an example: {0}! ", showDogName);
            var pupAge = 6;
            Console.WriteLine("{0} is currently {1} years old", showDogName, pupAge);


           
            string name = "Nellie";
            Constructor dog = new Constructor(name);
            Console.WriteLine("My dog's name is {0} and she is a {1} year old Border Collie.", dog.Name, dog.Age);
            Console.ReadLine();
        }
    }
}
