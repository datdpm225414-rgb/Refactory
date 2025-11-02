using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory50_RemoveSettingMethod_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(10);
            Console.WriteLine("Immutable Value: " + customer.setImmutableValue(20));
            Console.WriteLine("Immutable Value: " + customer.getImmutableValue());
            Console.ReadLine();

        }

    }
}
