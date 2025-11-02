using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DPM225414_TanNamDat_Refactory64_FormTemplateMethod_before
{
    internal class LifelineSite : Site
    {
        public override double GetBaseAmount()
        {
            return Units * Rate * 0.5;
        }

        public override double GetTaxAmount()
        {
            return GetBaseAmount() * 0.02;
        }
    }
}
