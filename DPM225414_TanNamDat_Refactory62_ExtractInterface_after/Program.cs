using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory62_ExtractInterface_after
{
    internal class Program
    {

    static void Main()
        {
            IBillable emp = new Employee();

            Console.WriteLine($"Rate: {emp.GetRate()}");
            Console.WriteLine($"Has special skill: {emp.HasSpecialSkill()}");
        }
    }
}
