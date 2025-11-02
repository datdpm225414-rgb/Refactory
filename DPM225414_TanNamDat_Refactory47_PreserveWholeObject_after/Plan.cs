using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory47_PreserveWholeObject_after
{
    internal class Plan
    {
        public bool WithinRande(DaysTempRange daysTempRange)
        {
            if (daysTempRange.Low < 10 || daysTempRange.High>30)
            {
                return false;
            }
            return true; 
        }
    }
}
