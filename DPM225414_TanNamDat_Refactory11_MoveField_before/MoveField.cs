using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory11_MoveField_before
{
    internal class MoveField
    {
        class Class1
        {
            public string name = "Nguyễn Văn A";
        }

        class Class2
        {
            public void ShowName(Class1 c1)
            {
                Console.WriteLine("Tên là: " + c1.name);
            }
        }
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Class1 cl = new Class1();
            Class2 cl2 = new Class2();
            cl2.ShowName(cl);

        }

    }
}
