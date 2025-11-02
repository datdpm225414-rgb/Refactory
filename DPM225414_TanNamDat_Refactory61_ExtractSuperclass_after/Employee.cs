using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory61_ExtractSuperclass_after
{
    internal class Employee :Party
    {
        public int Id { get; set; }
        public double AnnualCost { get; set; }

        public Employee(string name, int id, double annualCost)
            : base(name)
        {
            Id = id;
            AnnualCost = annualCost;
        }

        public int GetId() => Id;

        public override double GetAnnualCost()
        {
            return AnnualCost;
        }
    }
}
