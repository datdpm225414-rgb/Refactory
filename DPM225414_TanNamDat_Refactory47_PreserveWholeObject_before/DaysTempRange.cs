using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory47_PreserveWholeObject_before
{
    internal class DaysTempRange
    {
        private int _low;
        private int _high;
        public DaysTempRange(int low, int high)
        {
            _low = low;
            _high = high;
        }
        public int GetLow()
        {
            return _low;
        }
        public int GetHigh()
        {
            return _high;
        }
    }
}
