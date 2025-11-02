using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory50_RemoveSettingMethod_before
{
    internal class Customer
    {
        private int ImmutableValue;
        public Customer(int immutableValue)
        {
            ImmutableValue = immutableValue;
        }
        public int setImmutableValue(int newValue)
        {
            return ImmutableValue = newValue;
        }
        public int getImmutableValue()
        {
            return ImmutableValue;
        }
    }
}
