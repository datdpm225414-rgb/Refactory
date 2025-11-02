using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory61_ExtractSuperclass_before
{
    internal class Department
    {
        public string Name { get; set; }
        public double TotalAnnualCost { get; set; }
        public int HeadCount { get; set; }

        public Department(string name, double totalAnnualCost, int headCount)
        {
            Name = name;
            TotalAnnualCost = totalAnnualCost;
            HeadCount = headCount;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetTotalAnnualCost()
        {
            return TotalAnnualCost;
        }
        public int GetHeadCount()
        {
            return HeadCount;
        }
    }
}
