using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory52_ReplaceConstructorwithFactoryMethod_before
{
    public class Employee
    {
        private string type;
        public Employee(string type)
        {
            this.type = type;
        }

        public void Details()
        {
            Console.WriteLine("Employee Type: " + type);
        }
    }
}
