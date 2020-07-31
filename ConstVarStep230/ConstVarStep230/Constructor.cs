using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarStep230
{
    public class Constructor
    {
        public Constructor(string name) : this(name, 10)
        { 
        }

        public Constructor(string name, int dogAge)
        {
            Name = name;
            Age = dogAge;

        }

        public int Age { get; set; }
        public string Name { get; set; }
    }
    

}

