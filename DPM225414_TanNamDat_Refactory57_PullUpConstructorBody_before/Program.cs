using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory57_PullUpConstructorBody_before
{
    internal class Program
    {
        static void Main()
        {
            Manager manager = new Manager("Dat", 1, "A");
            manager.ShowInfo();
            Console.ReadLine();
        }
    }
}
