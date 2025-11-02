using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory46_ReplaceParameterwithExplicitMethods_after
{
    internal class Rectangle
    {
        private int height;
        private int width;

        public void SetHeight(int value)
        {
            height = value;
        }

        public void SetWidth(int value)
        {
            width = value;
        }

        public void Print()
        {
            Console.WriteLine($"Height = {height}, Width = {width}");
        }
    }
}
