using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory60_ExtractSubclass_after
{
    public  class JobItem
    {
        protected int Quantity;

        public JobItem(int quantity)
        {
            Quantity = quantity;
        }

        public virtual double GetUnitPrice()
        {
            return 50.0;
        }

        public double GetTotalPrice()
        {
            return GetUnitPrice() * Quantity;
        }

        public virtual Employee GetEmployee()
        {
            return null;
        }

    }
}
