using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory45_ParameterizeMethod_before
{
    internal class Employee
    {
        private double salary;
        public Employee(double salary)
        {
            this.salary = salary;
        }
        public void fivePercentRaise()
        {
            salary = salary * 1.05;
            Console.WriteLine("Salary: " + salary);
        }
        public void tenPercentRaise()
        {
            salary = salary * 1.10;
            Console.WriteLine("Salary: " + salary);
        }

    }
}
