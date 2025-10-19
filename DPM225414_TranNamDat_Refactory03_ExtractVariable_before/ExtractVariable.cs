using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Refactory03_ExtractVariable_before
{
    public class ExtractVariable
    {


        public bool wasInitialized()
        {
           
            return true;
        }
        void RenderBanner(string platform,string browser, int resize)
        {
            if ((platform.ToUpper().IndexOf("MAC") > -1) &&
                 (browser.ToUpper().IndexOf("IE") > -1) &&
                  wasInitialized() && resize > 0)
            {
                Console.WriteLine("Rendering banner for MacOS and IE...");
            }
            else
            {
                Console.WriteLine("Conditions not met. Banner not rendered.");
            }
        }

        public static void Main()
        {
            ExtractVariable extractVariable = new ExtractVariable();
            Console.WriteLine("Starting banner rendering test...");
            extractVariable.RenderBanner("MacOS", "IE11", 100);
            extractVariable.RenderBanner("WinDows", "Chrome", 10);


        }
    }
}
