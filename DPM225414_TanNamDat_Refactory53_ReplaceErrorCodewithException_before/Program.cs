using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory53_ReplaceErrorCodewithException_before
{
    internal class Program
    {
        static int _balance = 100;
        static int Withdraw(int amount)
        {
            if (amount > _balance)
            {
                return -1;
            }
            else
            {
                _balance -= amount;
                return 0;
            }
        }
        public static void Main()
        {
            int result = Withdraw(200);
            if (result == -1)
            {
                Console.WriteLine("Không đủ tiền trong tài khoản!");
            }
            else
            {
                Console.WriteLine("Rút tiền thành công!");
            }
        }


    }
}
