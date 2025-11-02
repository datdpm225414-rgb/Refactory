using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory65_ReplaceInheritance_Data_after
{
    internal class Program
    {

            static void Main()
            {
                Stack<int> stack = new Stack<int>();
                Console.WriteLine(stack.IsEmpty()); 
                stack.Push(10);
                Console.WriteLine(stack.IsEmpty()); 
            }
        
    }
}
