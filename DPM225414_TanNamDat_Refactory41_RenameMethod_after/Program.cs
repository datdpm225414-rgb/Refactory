using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory41_RenameMethod_after
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer("Tan", "Nam Dat");
            Console.WriteLine("Firstname: " + customer.getFirstName());
            Console.WriteLine("Secondname: " + customer.getSecondName());
            Console.ReadLine();
        }

    }
}
