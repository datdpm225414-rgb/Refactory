using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory59_PushDownField_before
{
    internal class Tank : Unit
    {
        public override void Move()
        {
            fuel -= 10;
            Console.WriteLine("Tank is moving. Remaining fuel: " + fuel);
        }

    }
}
