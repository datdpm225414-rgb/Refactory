using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory14_HideDelegate_after
{
    internal class HideDelegate
    {
        public class Department
        {
            private Person manager;

            public Department(Person manager)
            {
                this.manager = manager;
            }

            public Person GetManager()
            {
                return manager;
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

            public Person GetManager()
            {
                return department.GetManager();
            }

            public string GetName()
            {
                return name;
            }
        }
        public static void Main()
        {
            Person manager = new Person("Nguyen Van A", null);
            Department dept = new Department(manager);
            Person employee = new Person("Tran Nam Dat", dept);

            // Client gọi hàm getManager() của Person
            Console.WriteLine("Manager: " + employee.GetManager().GetName());
        }
    }
}
