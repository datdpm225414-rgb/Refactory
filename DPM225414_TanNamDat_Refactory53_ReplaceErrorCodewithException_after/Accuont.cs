using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory53_ReplaceErrorCodewithException_after
{
    internal class Accuont
    {
        private int _balance = 1000;
       
        public void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                throw new BalanceException();
            }
            _balance -= amount;
            Console.WriteLine($"Rút {amount} thành công. Số dư còn lại: {_balance}");
        }
    }
}
