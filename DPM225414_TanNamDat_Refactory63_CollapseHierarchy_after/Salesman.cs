using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory63_CollapseHierarchy_after
{
    internal class Salesman : Employee
    {

        public Salesman(string name) : base(name)
        {
        }

        public string GetName()
        {
            return base.GetName();
        }
    }
}
