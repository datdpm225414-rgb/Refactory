using System;

namespace DPM225414_TranNamDat_Refactory08_ReplaceMethodwithMethodObject_after
{
    public class Order
    {
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }

        public Order(int quantity, double itemPrice)
        {
            Quantity = quantity;
            ItemPrice = itemPrice;
        }

        public double Price()
        {
            return new PriceCalculator(this).Compute();
        }
    }

    public class PriceCalculator
    {
        private  Order order;
        private double primaryBasePrice;
        private double secondaryBasePrice;
        private double tertiaryBasePrice;

        public PriceCalculator(Order Order)
        {
            order = Order;
        }

        public double Compute()
        {
            primaryBasePrice = order.Quantity * order.ItemPrice;
            secondaryBasePrice = primaryBasePrice * 0.1;
            tertiaryBasePrice = Math.Max(0, order.Quantity - 100) * order.ItemPrice * 0.05;

            return primaryBasePrice - secondaryBasePrice + tertiaryBasePrice;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(120, 50); 
            Console.WriteLine("Giá cuối cùng: " + order.Price());
        }
    }
}
