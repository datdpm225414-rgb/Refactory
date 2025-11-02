using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory58_PushDownMethod_before
{
    internal class Tank : Unit
    {
        private int fuel;
        public Tank(int fuel)
        {
            this.fuel = fuel;
        }
        public override int GetFuel()
        {
            return fuel;
        }
        public void Move()
        {
            int fuel = GetFuel();
            if (fuel <= 0)
            {
                Console.WriteLine("Tank cannot move due to insufficient fuel.");
            }
            else
            {
                Console.WriteLine("Tank is moving.");
                fuel -= 10;
                Console.WriteLine("Remaining fuel : " + fuel);
            }
        }
    }
}
