using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOStep219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\lauri\Desktop\C#Projects\Logs\step219.txt", text);

            Console.WriteLine(File.ReadAllText(@"C:\Users\lauri\Desktop\C#Projects\Logs\step219.txt"));
            Console.ReadLine();
        }
    }
}
