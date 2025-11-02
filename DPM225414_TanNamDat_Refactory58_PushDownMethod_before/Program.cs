using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory58_PushDownMethod_before
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tank tank = new Tank(100);
            tank.Move();
            Console.ReadLine();
        }
    }
}
