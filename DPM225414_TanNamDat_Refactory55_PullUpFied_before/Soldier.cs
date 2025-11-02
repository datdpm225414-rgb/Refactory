using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory55_PullUpFied_before
{
    internal class Soldier : Unit
    {
        private int health;
        public Soldier(int health)
        {
            this.health = health;
        }
        public void Details()
        {
            Console.WriteLine("Tank Health: " + health);
        }
    }
}
