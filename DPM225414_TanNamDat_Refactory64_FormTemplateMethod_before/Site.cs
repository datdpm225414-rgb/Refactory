using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory64_FormTemplateMethod_before
{
    public abstract class Site
    {
        public double Units { get; set; }
        public double Rate { get; set; }

        public double GetBillableAmount()
        {
            return GetBaseAmount() + GetTaxAmount();
        }

        // Các hàm trừu tượng (bắt buộc lớp con phải override)
        public abstract double GetBaseAmount();
        public abstract double GetTaxAmount();
    }
}
