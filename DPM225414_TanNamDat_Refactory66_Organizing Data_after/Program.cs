using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory66_Organizing_Data_after
{
    internal class Program
    {
        static void Main()
        {
            Person p = new Person("Tran Nam Nam");
            Employee e = new Employee(p);

            Console.WriteLine("Employee name: " + e.GetName());
        }
    }
}
