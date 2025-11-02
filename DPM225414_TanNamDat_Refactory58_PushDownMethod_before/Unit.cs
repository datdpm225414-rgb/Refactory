using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory58_PushDownMethod_before
{
    public abstract  class Unit
    {
        public string Name { get; set; }

        public abstract int GetFuel();

    }
}
