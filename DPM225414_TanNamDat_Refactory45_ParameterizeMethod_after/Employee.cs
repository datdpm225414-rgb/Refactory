using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory45_ParameterizeMethod_after
{
    internal class Employee
    {
        private double salary;
        public Employee(double salary)
        {
            this.salary = salary;
        }
        public void raise(double percentage)
        {
            salary += salary * percentage / 100;
            Console.WriteLine("Salary: " + salary);
        }
    }
}
