using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory64_FormTemplateMethod_after
{
    internal class ResidentialSite
    {
        public double Units { get; set; }
        public double Rate { get; set; }

        public double GetBillableAmount()
        {
            double baseAmount = Units * Rate;
            double tax = baseAmount * 0.05;
            return baseAmount + tax;
        }
    }
}
