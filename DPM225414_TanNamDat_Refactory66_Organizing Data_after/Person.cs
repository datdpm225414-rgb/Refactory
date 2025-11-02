using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory66_Organizing_Data_after
{
    internal class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
