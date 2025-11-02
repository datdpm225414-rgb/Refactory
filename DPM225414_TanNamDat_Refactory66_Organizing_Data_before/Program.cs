using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory66_Organizing_Data_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Tan Nam Dat");
            Console.WriteLine("Employee Name: " + employee.GetEmployeeName());
            Console.ReadLine();
        }
    }
}
