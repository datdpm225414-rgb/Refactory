using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory60_ExtractSubclass_before
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Rate { get; set; }

        public Employee(string name, double rate)
        {
            Name = name;
            Rate = rate;
        }
    }
}
