using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory46_ReplaceParameterwithExplicitMethods_after
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetHeight(10);
            rectangle.SetWidth(20);
            rectangle.Print();
            Console.ReadLine();
        }

    }
}
