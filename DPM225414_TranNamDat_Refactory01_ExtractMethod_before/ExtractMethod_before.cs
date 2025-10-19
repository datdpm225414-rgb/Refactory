using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Refactory01_ExtractMethod_before
{
    internal class ExtractMethod_before
    {
        private string name;
        private double amount;

        // Constructor để gán giá trị ban đầu
        public ExtractMethod_before(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public void PrintBanner()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("***** Customer Owes *******");
            Console.WriteLine("****************************");
        }

        public void PrintOwing()
        {
            this.PrintBanner();
            this.PrintDetails();
        }

        private void PrintDetails()
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
        }

        private double GetOutstanding()
        {
            return this.amount;
        }



        static void Main(string[] args)
        {
            ExtractMethod_before customer = new ExtractMethod_before("Nam Đạt", 1500.5);
            customer.PrintOwing();
        }
    }
}
