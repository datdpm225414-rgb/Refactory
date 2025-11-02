using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory60_ExtractSubclass_after
{
    public class Employee
    {
        private string _name;
        private double _rate;

        public Employee(string name, double rate)
        {
            _name = name;
            _rate = rate;
        }

        public string GetName()
        {
            return _name;
        }
        public double GetRate()
        {
            return _rate;
        }
    }
}
