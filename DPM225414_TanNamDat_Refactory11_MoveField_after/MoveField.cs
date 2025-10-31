using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory11_MoveField_after
{
    internal class MoveField
    {
        class Class1
        {
        }

        class Class2
        {            
            public string name = "Nguyễn Văn A";

            public void ShowName()
            {
                Console.WriteLine("Tên là: " + name);
            }
        }
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Class2 cl2 = new Class2();
            cl2.ShowName();

        }
    }
}
