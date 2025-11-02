using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory56_PullUpMethod_before
{
    internal class Tank : Unit
    {
        private int Health;
        public Tank(int health)
        {
            Health = health;
        }
        public int GetHealth()
        {
            return Health;
        }

    }
}
