using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory42_AddParameter_before
{
    internal class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.GetContact());
            Console.ReadLine(); 
        }
    }
}
