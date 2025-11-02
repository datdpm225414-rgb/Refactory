using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory62_ExtractInterface_after
{
    public class Employee : IBillable
    {
        public string GetName()
        {
            return "Nam";
        }

        public string GetDepartment()
        {
            return "Sales";
        }

        public double GetRate()
        {
            return 100.0;
        }

        public bool HasSpecialSkill()
        {
            return true;
        }
    }
}
