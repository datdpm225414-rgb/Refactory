using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory52_ReplaceConstructorwithFactoryMethod_before
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Manager");
            employee.Details();
            Console.ReadLine();
        }
    }
}
