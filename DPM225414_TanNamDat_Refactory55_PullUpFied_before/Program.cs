using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory55_PullUpFied_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier(100);
            soldier.Details();
            Tank tank = new Tank(70);
            tank.Details();
            
        }

    }
}
