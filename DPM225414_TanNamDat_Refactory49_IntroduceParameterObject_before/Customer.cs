using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory49_IntroduceParameterObject_before
{
    internal class Customer
    {
        public decimal AmountInvoicedIn(DateTime start, DateTime end)
        {
            return 1000m;
        }

        public decimal AmountReceivedIn(DateTime start, DateTime end)
        {
            return 800m;
        }

        public decimal AmountOverdueIn(DateTime start, DateTime end)
        {
            return 200m;
        }
    }
}
