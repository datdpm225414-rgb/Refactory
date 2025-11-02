using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory54_ReplaceExceptionwithTest_after
{
    internal class Program
    {
        static double[] values = { 10.5, 20.0, 30.7 };

        static void Main()
        {
            for (int i = 0; i < 5; i++) 
            {
                double result = GetValueForPeriod(i);
                Console.WriteLine($"Value for period {i}: {result}");
            }

            Console.ReadLine();
        }

        static double GetValueForPeriod(int periodNumber)
        {
            if (values == null || periodNumber < 0 || periodNumber >= values.Length)
            {
                return 0; 
            }

            return values[periodNumber];
        }
    }
}
