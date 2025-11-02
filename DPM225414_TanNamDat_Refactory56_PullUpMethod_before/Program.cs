using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory56_PullUpMethod_before
{
    internal class Program
    {
        static void Main()
        {
            Tank tank = new Tank(100);
            Console.WriteLine("Tank Health: " + tank.GetHealth());
            Soldier soldier = new Soldier(80);
            Console.WriteLine("Soldier Health: " + soldier.GetHealth());
            Console.ReadLine();

        }
    }
}
