using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory43_RemoveParameter_before
{
    internal class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            string contact = customer.GetContact(DateTime.Now);
            Console.WriteLine(contact);
        }
    }
}
