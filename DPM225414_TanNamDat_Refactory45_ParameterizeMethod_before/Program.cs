using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory45_ParameterizeMethod_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1000);
            emp.fivePercentRaise();
            emp.tenPercentRaise();
            Console.ReadLine();
        }
    }
}
