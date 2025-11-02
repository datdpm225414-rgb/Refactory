using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory60_ExtractSubclass_before
{
    internal class JobItem
    {
       
        private int _quantity;
        private bool _isLabor;
        private Employee _employee;

        public JobItem(int quantity, bool isLabor, Employee employee)
        {
            _quantity = quantity;
            _isLabor = isLabor;
            _employee = employee;
        }

        public double GetUnitPrice()
        {
            return _isLabor ? _employee.Rate : 50.0; 
        }
        public double GetTotalPrice()
        {
            return GetUnitPrice() * _quantity;
        }

        public Employee GetEmployee()
        {
            return _employee;
        }
    }
}
