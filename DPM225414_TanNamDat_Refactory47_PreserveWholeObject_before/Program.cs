using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory47_PreserveWholeObject_before
{
    internal class Program

    {
        static void Main()
        {
            DaysTempRange daysTempRange = new DaysTempRange(10, 25);
            Plan plan = new Plan();
            int low = daysTempRange.GetLow();
            int high = daysTempRange.GetHigh();
            bool withinPlan = plan.WithinRange(low, high);
            Console.WriteLine("Is within plan: " + withinPlan);
            Console.ReadLine();
        }
    }
}
