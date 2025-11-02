using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory63_CollapseHierarchy_after
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Nam Dat");
            Console.WriteLine("Salesman Name: " + emp.GetName());
        }
    }
}
