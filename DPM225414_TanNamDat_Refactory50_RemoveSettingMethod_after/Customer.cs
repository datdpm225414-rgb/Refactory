using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory50_RemoveSettingMethod_after
{
    internal class Customer
    {
        private  int immutableValue;

        public Customer(int value)
        {
            immutableValue = value;
        }

        public int GetImmutableValue()
        {
            return immutableValue;
        }
    }
}
