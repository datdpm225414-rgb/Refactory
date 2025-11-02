using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory60_ExtractSubclass_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Dat", 5000);
            Console.WriteLine($"Employee Name: {emp.Name}, Rate: {emp.Rate}");
            JobItem laborItem = new JobItem(2, true, emp);
            JobItem materialItem = new JobItem(5, false, emp);
            Console.WriteLine($"Labor Item Total Price: {laborItem.GetTotalPrice()}");
            Console.WriteLine($"Material Item Total Price: {materialItem.GetTotalPrice()}");
            Console.ReadLine();
        }
    }
}
