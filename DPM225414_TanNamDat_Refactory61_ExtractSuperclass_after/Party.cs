using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory61_ExtractSuperclass_after
{
    public abstract class Party
    {
        public string Name { get; set; }

        public Party(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract double GetAnnualCost();
    }
}
