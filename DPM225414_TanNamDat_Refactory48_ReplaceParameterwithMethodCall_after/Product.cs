using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory48_ReplaceParameterwithMethodCall_after
{
    internal class Product
    {
        private int quantity = 5;
        private int itemPrice = 100;

        public double GetDiscount()
        {
            return 50;
        }

        public double GetFee()
        {
            return 20;
        }

        public double DiscountedPrice()
        {
            int basePrice = quantity * itemPrice;
            double discount = GetDiscount();
            double fee = GetFee();
            return basePrice - discount + fee;
        }

        public void PrintPrice()
        {
            double finalPrice = DiscountedPrice();
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
}
