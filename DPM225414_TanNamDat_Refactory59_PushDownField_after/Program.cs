using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory59_PushDownField_after
{
    internal class Program
    {
        static void Main()
        {

            Soldier soldier = new Soldier();
            Tank tank = new Tank();
            int count = 0;
            Console.WriteLine("Nhập số lần di chuyển:" );
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
                tank.Move();
            soldier.Move();
            Console.ReadLine();
        }
    }
}
