using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory52_ReplaceConstructorwithFactoryMethod_after
{
    public class Employee
    {
        private string type;
        public Employee(string type) {
            this.type = type;
        }
        public static Employee Create(string type)
        {
            Employee employee = new Employee(type);
            return employee;
        }
        public void ShowEmployeeType()
        {
            if(type == "1")
            {
                Console.WriteLine("This is a Software Engineer.");
            }
            else if (type == "2")
            {
                Console.WriteLine("This is a Hardware Engineer.");
            }
            else
            {
                Console.WriteLine("Unknown Employee Type.");
            }   
        }
    }
}
