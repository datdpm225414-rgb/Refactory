using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory47_PreserveWholeObject_after
{
    internal class Program

    {
        static void Main(string[] args)
        {
            DaysTempRange daysTempRange = new DaysTempRange(5, 50);
            Plan plan = new Plan();
            bool result = plan.WithinRande(daysTempRange);
            Console.WriteLine("Is within range: " + result);
            Console.ReadLine();
        }

    }
}
