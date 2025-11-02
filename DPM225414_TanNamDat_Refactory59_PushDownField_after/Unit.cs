using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory59_PushDownField_after
{
    public abstract class Unit
    {
        public virtual void Move()
        {
            Console.WriteLine("Unit is moving");
        }
    }
}
