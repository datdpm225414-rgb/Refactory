using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory61_ExtractSuperclass_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dp = new Department("IT", 5000000, 50);
            Employee emp = new Employee("Dat", 200000, "DPM225414");
            Console.WriteLine("Department Name: " + dp.GetName() + dp.GetHeadCount);
            Console.WriteLine("Employee Name: " + emp.GetName() + emp.ID);
            


        }
    }
}
