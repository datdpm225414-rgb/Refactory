using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory44_SeparateQueryfromModifier_after
{
    internal class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            double totalOutstanding = customer.GetTotalOutstanding();
            Console.WriteLine("Total Outstanding: " + totalOutstanding);
            customer.SetReadyForSummaries();
            Console.ReadLine();
        }
    }
}
