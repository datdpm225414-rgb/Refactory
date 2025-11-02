using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DPM225414_TanNamDat_Refactory66_Organizing_Data_before
{
    public class Employee : Person
    {
        public Employee(string name) : base(name)
        {
        }

        public string GetEmployeeName()
        {
            return base.GetName();
        }
    }
}
