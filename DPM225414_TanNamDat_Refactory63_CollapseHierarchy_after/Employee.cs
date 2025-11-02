using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory63_CollapseHierarchy_after
{
    internal class Employee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}
