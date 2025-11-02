using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory58_PushDownMethod_after
{
    internal class Tank : Unit
    {
        private int fuel;
        public Tank(int fuel)
        {
            this.fuel = fuel;
        }
        public int GetFuel()
        {
            return fuel;
        }
    }
}
