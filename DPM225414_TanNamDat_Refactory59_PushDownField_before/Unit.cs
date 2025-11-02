using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory59_PushDownField_before
{
    public class Unit
    {
        protected int  fuel;
        public virtual void Move()
        {
            Console.WriteLine("Unit is moving.");
        }
    }
}
