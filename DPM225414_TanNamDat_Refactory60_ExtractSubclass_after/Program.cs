using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory60_ExtractSubclass_after
{
    internal class Program
    {
        static void Main()
        {
            Employee e = new Employee("Nam", 100);

            JobItem material = new JobItem(5);    
            JobItem labor = new LaborItem(3, e);           

            Console.WriteLine("Material total:" +material.GetTotalPrice);
            Console.WriteLine("Labor total:"+labor.GetTotalPrice());
        }
    }
}
