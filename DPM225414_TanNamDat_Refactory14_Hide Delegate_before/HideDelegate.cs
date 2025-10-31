using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory14_Hide_Delegate_before
{
    internal class HideDelegate
    {
        public class Department
        {
            private string name;
            private Person manager;

            public Department(string name, Person manager)
            {
                this.name = name;
                this.manager = manager;
            }

            public Person GetManager()
            {
                return manager;
            }

            public string GetName()
            {
                return name;
            }
        }

        public class Person
        {
            private string name;
            private Department department;

            public Person(string name, Department department)
            {
                this.name = name;
                this.department = department;
            }

            public Department GetDepartment()
            {
                return department;
            }

            public string GetName()
            {
                return name;
            }
        }

        public class ClientClass
        {
            public static void Main()
            {
                Person manager = new Person("Nguyen Van A", null);
                Department dept = new Department("IT Department", manager);
                Person employee = new Person("Tran Nam Dat", dept);

                Console.WriteLine("Employee: " + employee.GetName());
                Console.WriteLine("Department: " + employee.GetDepartment().GetName());
                Console.WriteLine("Manager: " + employee.GetDepartment().GetManager().GetName());
            }
        }
    }
}
