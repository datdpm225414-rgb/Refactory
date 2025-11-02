using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory63_CollapseHierarchy_before
{
    internal class Employeee
    {
        private string name { get; set; }
        private string type { get; set; }

        public Employeee(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string Type()
        {
            return name + " is a " + type;
        }

    }
}
