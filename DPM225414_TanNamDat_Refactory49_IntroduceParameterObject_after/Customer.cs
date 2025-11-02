using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory49_IntroduceParameterObject_after
{
    internal class Customer
    {
        public decimal AmountInvoicedIn(DateRange date)
        {
            return 1000m;
        }

        public decimal AmountReceivedIn(DateRange date)
        {
            return 800m;
        }

        public decimal AmountOverdueIn(DateRange date)
        {
            return 200m;
        }
    }
}
