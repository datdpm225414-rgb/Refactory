using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Refactory02_InlineMethod_after
{
    internal class InlineMethod
    {
        class PizzaDelivery
        {
            public int GetRating( int Num)
            {
                return MoreThanFiveLateDeliveries(Num) ? 2 : 1;
            }

             public bool MoreThanFiveLateDeliveries(int numberOfLateDeliveries)
            {
                return numberOfLateDeliveries > 5;
            }
        }

        static void Main()
        {
            PizzaDelivery delivery = new PizzaDelivery();

            Console.WriteLine("Rating: " + delivery.GetRating(0));
            Console.ReadLine();
        }

    }
}
