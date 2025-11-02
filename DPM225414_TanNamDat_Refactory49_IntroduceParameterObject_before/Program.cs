using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory49_IntroduceParameterObject_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            DateTime start = new DateTime(2023, 1, 1);
            DateTime end = new DateTime(2023, 1, 1);
            decimal invoiced = customer.AmountInvoicedIn(start, end);
            decimal received = customer.AmountReceivedIn(start, end);
            decimal overdue = customer.AmountOverdueIn(start, end);
            Console.WriteLine($"Amount Invoiced: {invoiced}");
            Console.WriteLine($"Amount Received: {received}");
            Console.WriteLine($"Amount Overdue: {overdue}");
        }

    }
}
