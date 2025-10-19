using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Refactory06_SplitTemporaryVariable_before
{
    public class SplitTemporaryVariable
    {
        public static void Main()
        {
            int continiue = 0;
            while (continiue == 0)
            {
                Console.WriteLine("Nhap chieu dai hinh chu nhat: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhap chieu rong hinh chu nhat: ");
                double width = Convert.ToDouble(Console.ReadLine());
                double temp = 2 * (height + width);
                Console.WriteLine(temp);
                temp = height * width;
                Console.WriteLine(temp);
                Console.WriteLine("Ban co muon tiep tuc tiep tuc, yes or no : ");
                if (Console.ReadLine() == "no")
                {
                    continiue = 1;
                }

            }

        }
    }
}
