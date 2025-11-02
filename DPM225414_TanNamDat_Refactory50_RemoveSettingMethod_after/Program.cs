using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory50_RemoveSettingMethod_after
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(42);
            Console.WriteLine("Immutable Value: " + customer.GetImmutableValue());
            Console.ReadLine();
        }



    }
}
