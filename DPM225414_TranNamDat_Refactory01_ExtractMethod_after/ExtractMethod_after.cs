using System;

namespace DPM225414_TranNamDat_Refactory01_ExtractMethod_after
{
    public class ExtractMethod_after
    {   
        void PrintOwing()
        {
           

            this.PrintBanner();

            // Print details.
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
        }
    }
    
}
