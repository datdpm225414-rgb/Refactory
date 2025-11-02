using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory53_ReplaceErrorCodewithException_after
{
    internal class BalanceException : Exception
    {
        public BalanceException() : base("Không đủ tiền trong tài khoản!") { }
    }
}
