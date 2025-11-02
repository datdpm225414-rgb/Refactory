using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory42_AddParameter_after
{
    internal class Customer
    {
        public string GetContact(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Sunday)
                return "Email: weekend-support@example.com";
            else
                return "Email: weekdays-support@example.com";
        }
    }
}
