using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory56_PullUpMethod_before
{
    internal class Soldier : Unit
    {
        private int Health;
        public Soldier(int health)
        {
            Health = health;
        }
        public int GetHealth()
        {
            return Health;
        }
    }
}
