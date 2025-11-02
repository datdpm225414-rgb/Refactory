using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory49_IntroduceParameterObject_after
{
    public class DateRange
    {
        public DateTime Start { get; }
        public DateTime End { get; }
        public DateRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public bool Includes(DateTime date)
        {
            return date >= Start && date <= End;
        }
    }
}
