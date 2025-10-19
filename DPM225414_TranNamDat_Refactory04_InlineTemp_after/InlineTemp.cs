using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Refactory04_InlineTemp_after
{
    public class InlineTemp
    {
        bool HasDiscount(Order order)
        {
            return order.BasePrice() > 1000;
        }
        public static void Main()
        {
            Order order = new Order(5, 300);
            InlineTemp inlineTemp = new InlineTemp();
            bool hasDiscount = inlineTemp.HasDiscount(order);
            Console.WriteLine("Has Discount: " + hasDiscount);
        }
    }
}
