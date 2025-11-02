using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory55_PullUpFied_after
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.DetailSoldier();
            Tank tank = new Tank();
            tank.DetailTank();
            Console.ReadLine();
        }
    }
}
