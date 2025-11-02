using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory47_PreserveWholeObject_before
{
    internal class Plan
    {
        public bool WithinRange(int low, int high)
        {
            if (low < 20 || high > 30)
            {
                return false;
            }
            return true;
        }
    }
}
