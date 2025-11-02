using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory46_ReplaceParameterwithExplicitMethods_before
{
    internal class Rectangle
    {
        private int height;
        private int width;
        public void SetValue(string name, int value)
        {
            if (name.Equals("height"))
            {
                height = value;
                return;
            }
            if (name.Equals("width"))
            {
                width = value;
                return;
            }
            Debug.Fail("Invalid property name!");
        }
        public void Print()
        {
            Console.WriteLine("Height = " +height+  "Width = " + width);
        }
    }
}
