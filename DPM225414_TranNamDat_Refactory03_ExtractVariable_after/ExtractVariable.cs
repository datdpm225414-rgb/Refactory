using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Refactory03_ExtractVariable_after
{
    public class ExtractVariable
    {
        private  string platform;
        private string browser;
        private  int resize;
        public bool wasInitialized()
        {
            // some code here
            return true;
        }
        public ExtractVariable(string platform, string browser, int resize)
        {
            this.platform = platform;
            this.browser = browser;
            this.resize = resize;
        }
        void RenderBanner()
        {
             bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
             bool isIE = browser.ToUpper().IndexOf("IE") > -1;
             bool wasResized = resize > 0;

            if (isMacOs && isIE && wasInitialized() && wasResized)
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
            Console.WriteLine("Starting banner rendering test...");

            ExtractVariable extractVariable1= new ExtractVariable("MacOS", "IE11", 100);
            extractVariable1.RenderBanner();
            ExtractVariable extractVariable2 = new ExtractVariable("WinDows", "Chrome", 10);
            extractVariable2.RenderBanner();    



        }
    }
    
}
