using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory53_ReplaceErrorCodewithException_after
{
    internal class Program
    {

        static void Main()
        {
            Accuont account = new Accuont();
            try
            {
                account.Withdraw(500);
            }
            catch (BalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
