using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory61_ExtractSuperclass_after
{
    internal class Department : Party
    {
        public int HeadCount { get; set; }
        public double TotalAnnualCost { get; set; }

        public Department(string name, int headCount, double totalAnnualCost)
            : base(name)
        {
            HeadCount = headCount;
            TotalAnnualCost = totalAnnualCost;
        }

        public int GetHeadCount() => HeadCount;

        public override double GetAnnualCost()
        {
            return TotalAnnualCost;
        }
    }
}
