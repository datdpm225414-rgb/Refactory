using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory42_AddParameter_after
{
    internal class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            DateTime date = new DateTime(2023, 10, 1); 
            string contactInfo = customer.GetContact(date);
            Console.WriteLine(contactInfo);
            string contact = customer.GetContact(DateTime.Now);
            Console.WriteLine("Thời gian hiện tại: " + DateTime.Now);
            Console.WriteLine("Liên hệ: " + contact);
            Console.ReadLine();
        }

    }
}
