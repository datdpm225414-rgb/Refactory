using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory58_PushDownMethod_after
{
    internal class Program
    {
        static void Main()
        {
            Tank tank = new Tank(100);
            Console.WriteLine("Tank fuel: " + tank.GetFuel());
            Console.ReadLine();
        }
    }
}
