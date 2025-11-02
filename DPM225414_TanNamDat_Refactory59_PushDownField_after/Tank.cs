using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory59_PushDownField_after
{
    internal class Tank : Unit
    {
        private int fuel = 100;
        public override void Move()
        {
            if (fuel >= 10)
            {
                fuel -= 10;
                Console.WriteLine("Tank is moving..");
                Console.WriteLine("Remaining fuel: " + fuel);
            }
            else
            {
                Console.WriteLine("Not enough fuel to move the tank.");
            }
        }
    }
}
