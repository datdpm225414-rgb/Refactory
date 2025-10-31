using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory10_MoveMethod_before
{
    internal class MoveMethod
    {
        class Class1
        {
            public void aMethod(Class2 c2)
            {
                Console.WriteLine(@"Phương thức aMethod đang sử dụng dữ liệu trong Class2: " + c2.SomeData);
            }
        }

        class Class2
        {
            public string SomeData = "Chao ban nhe!";
        }
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Class1 cl = new Class1();
            Class2 cl2 = new Class2();
            cl.aMethod(cl2);

        }
    }
}
