using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Step152
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 2, 4, 6, 8, 16, 32, 64, 128 };

            try
            {
                Console.WriteLine("Please give a number and this program will divide each number in the list by the number entered.");
                int div1 = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < numList.Count; i++)
                {
                    int result = numList[i] / div1;
                    Console.WriteLine(numList[i] + " divided by " + div1 + " = " + result);

                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }


}
 