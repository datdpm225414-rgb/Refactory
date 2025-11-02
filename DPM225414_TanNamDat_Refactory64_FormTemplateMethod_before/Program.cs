using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory64_FormTemplateMethod_before
{
    internal class Program
    {
        static void Main()
        {
            Site s1 = new ResidentialSite { Units = 100, Rate = 2.5 };
            Site s2 = new LifelineSite { Units = 100, Rate = 2.5 };

            Console.WriteLine($"Nhà dân: {s1.GetBillableAmount()}");
            Console.WriteLine($"Hộ nghèo: {s2.GetBillableAmount()}");
        }
    }
}
