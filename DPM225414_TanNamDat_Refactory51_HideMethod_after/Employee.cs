using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory51_HideMethod_after
{
    internal class Employee
    {
        public void CalculateBonus()
        {
            double bonus = GetBaseBonus() * 1.2;
            Console.WriteLine("Bonus: " + bonus);
        }

        private double GetBaseBonus()
        {
            return 1000;
        }
    }
}
