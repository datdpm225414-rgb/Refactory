using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory44_Separate_Query_from_Modifier_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            double totalOutstanding = customer.GetTotalOutstandingAndSetReadyForSummaries();
            Console.WriteLine($"Total Outstanding: {totalOutstanding}");
            Console.ReadLine();
        }


    }
}
