using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory59_PushDownField_before
{
    internal class Program
    {
        static void Main()
        {
            Unit tank = new Tank();
            tank.Move();
            Unit soldier = new Soldier();
            soldier.Move();
            Console.ReadLine();
        }
    }
}
