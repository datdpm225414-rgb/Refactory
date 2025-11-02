using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory41_RenameMethod_before
{
    internal class Program
    {
        public static void Main()
        {
            Customer customer = new Customer("Tan", "Nam Dat");
            Console.WriteLine("Firstname: " + customer.getFirstname());
            Console.WriteLine("Secondname: " + customer.getsnm());
            Console.ReadLine();
        }

    }
}
