using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory63_CollapseHierarchy_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employeee emp = new Employeee("Dat", "salesman");
            Console.WriteLine(emp.Type());
            Console.ReadLine();
        }
    }
}
