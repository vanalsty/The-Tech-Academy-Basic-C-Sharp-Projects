using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. concatenate three strings

            string childName = "Kalei";
            string childOrder = "youngest"; 
            string childSport = "ice hockey";
            
            Console.WriteLine("My daughter " + childName + " is my " +childOrder + " child and she plays " + childSport + ".");
            Console.ReadLine();

            //2. string to uppercase.

            childName = childName.ToUpper();
            Console.WriteLine(childName);
            Console.ReadLine();

            //3. create a stringbuilder

            StringBuilder sb = new StringBuilder("  Once upon a time I had to write a paragraph.");
            sb.Append(" it's for my C# coding class and ");
            sb.Append("I really don't know what to say.");
            sb.Append("I'm not much of a story teller ");
            sb.Append("but I will throw together some sentences and ");
            sb.Append("hope they form some sort of paragraph. ");
            sb.Append("Do you think it worked?");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
