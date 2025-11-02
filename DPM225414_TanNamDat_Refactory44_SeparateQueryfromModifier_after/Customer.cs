using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory44_SeparateQueryfromModifier_after
{
    internal class Customer
    {
        private bool readyForSummaries;
        private List<double> invoices = new List<double> { 100, 200, 300 };

        public double GetTotalOutstanding()
        {
            double total = 0;
            foreach (var i in invoices)
                total += i;
            return total;
        }

        public void SetReadyForSummaries()
        {
            readyForSummaries = true;
        }
    }
}
