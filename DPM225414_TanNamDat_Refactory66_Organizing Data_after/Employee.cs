using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory66_Organizing_Data_after
{
    internal class Employee
    {
        private Person _person;

        public Employee(Person person)
        {
            _person = person;
        }

        
        public string GetName()
        {
            return _person.GetName();
        }
    }
}
