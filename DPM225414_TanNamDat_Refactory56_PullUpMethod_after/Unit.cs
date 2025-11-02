using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory56_PullUpMethod_after
{
    public abstract class Unit
    {
        private int health;
        public Unit(int health)
        {
            this.health = health;
        }
        public int GetHealth()
        {
            return health;
        }

    }
}
