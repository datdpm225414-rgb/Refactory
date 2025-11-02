using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory45_ParameterizeMethod_after
{
    internal class Program
    {
        static void Main()
        {
            Employee emp = new Employee(5000);
            emp.raise(10); 
            emp.raise(20);
            Console.ReadLine();
        }
    }
}
