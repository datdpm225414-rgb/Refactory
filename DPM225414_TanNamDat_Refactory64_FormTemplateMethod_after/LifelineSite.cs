using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory64_FormTemplateMethod_after
{
    internal class LifelineSite
    {
        public double Units { get; set; }
        public double Rate { get; set; }

        public double GetBillableAmount()
        {
            double baseAmount = Units * Rate * 0.5; 
            double tax = baseAmount * 0.02;
            return baseAmount + tax;
        }
    }
}
