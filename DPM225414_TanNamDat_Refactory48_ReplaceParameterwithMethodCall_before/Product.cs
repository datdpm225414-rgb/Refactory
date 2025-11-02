using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory48_ReplaceParameterwithMethodCall_after
{
    public class Product
    {
        private int quantity = 5;
        private int itemPrice = 100;

        public double GetSeasonalDiscount()
        {
            return 50;
        }

        public double GetFee()
        {
            return 20; 
        }

        public double Discounted(int basePrice, double discount, double fee)
        {
            return basePrice - discount + fee;
        }

        public void PrintPrice()
        {
            int basePrice = quantity * itemPrice;
            double discount = this.GetSeasonalDiscount();
            double fee = GetFee();
            double finalPrice = Discounted(basePrice, discount, fee);

            Console.WriteLine("Final Price: " + finalPrice);
        }

    }
}
