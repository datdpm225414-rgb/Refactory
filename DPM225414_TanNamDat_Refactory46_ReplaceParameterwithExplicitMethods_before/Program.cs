using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory46_ReplaceParameterwithExplicitMethods_before
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.SetValue("height", 10);
            rec.SetValue("width", 20);
            rec.Print();
            Console.ReadLine();
        }
    }
}
