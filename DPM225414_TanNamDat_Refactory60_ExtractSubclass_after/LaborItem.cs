using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory60_ExtractSubclass_after
{
    internal class LaborItem : JobItem
    {
        private Employee _employee;

        public LaborItem(int quantity, Employee employee)
            : base(quantity)
        {
            _employee = employee;
        }

        public override double GetUnitPrice()
        {
            return _employee.GetRate();
        }

        public override Employee GetEmployee()
        {
            return _employee;
        }
    }
}
