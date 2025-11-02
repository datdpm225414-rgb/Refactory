using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory57_PullUpConstructorBody_after
{
    public class Program
    {
        public static void Main()
        {
            Manager manager = new Manager("Dat", "DPM225414", "A");
            manager.Details();
        }
    }
}
