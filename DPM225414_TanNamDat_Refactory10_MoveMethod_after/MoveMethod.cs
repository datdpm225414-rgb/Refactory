using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory10_MoveMethod_after
{
    internal class MoveMethod
    {
        class Class1
        {
        }

        class Class2
        {
            public string SomeData = "Chao ban nhe";

            public void aMethod()
            {
                Console.WriteLine("Phương thức aMethod đang sử dụng dữ liệu trong Class2: " + SomeData);
            }
        }

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Class2 cl2 = new Class2();
            cl2.aMethod();
        }
    }
}
