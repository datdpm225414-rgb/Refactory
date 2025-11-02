using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory61_ExtractSuperclass_after
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee("Tran Dat", 1, 60000);
            Department dept = new Department("HR", 10, 500000);
            Console.WriteLine($"Employee: {emp.GetName()}, ID: {emp.GetId()}, Annual Cost: {emp.GetAnnualCost()}");
            Console.WriteLine($"Department: {dept.GetName()}, Head Count: {dept.GetHeadCount()}, Annual Cost: {dept.GetAnnualCost()}");
        }
    }
}
