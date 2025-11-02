using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory54_ReplaceExceptionwithTest_before
{
    internal class Program
    {
        static double[] values = { 10.5, 20.0, 30.7 };
         public static double GetValueForPeriod(int periodNumber)
        {
            try
            {
                return values[periodNumber];
            }
            catch (IndexOutOfRangeException e)
            {
                return 0;
            }
        }
        public static void Main()
        {

            double result;


            for (int i = 0; i < values.Length; i++)
            {
               result = GetValueForPeriod(i); 
                Console.WriteLine($"Value for period {i}: {result}");
            }

            Console.ReadLine();
        }
    }
}
