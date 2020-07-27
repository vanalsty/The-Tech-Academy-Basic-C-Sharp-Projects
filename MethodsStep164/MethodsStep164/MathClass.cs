using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsStep164
{
    class MathClass
    {
        public static int Multiply(int x, int y)
        {
            int result = x * y;
            return result;
        }

        public static decimal Add(decimal x, int y)
        {
            decimal result = (int)(x + y);
            return (decimal)result;
        }

        public static int Divide(string x, int y)
        {
            int num5 = Convert.ToInt32(x);
            int result1 = num5 / y;
            return result1;
        }

    }
}
