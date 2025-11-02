using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory49_IntroduceParameterObject_after
{
    public class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            DateRange dateRange = new DateRange(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31));
            decimal invoiced = customer.AmountInvoicedIn(dateRange);
            decimal received = customer.AmountReceivedIn(dateRange);
            decimal overdue = customer.AmountOverdueIn(dateRange);
            Console.WriteLine($"Amount Invoiced: {invoiced}");
            Console.WriteLine($"Amount Received: {received}");
            Console.WriteLine($"Amount Overdue: {overdue}");
        }
    }
}
