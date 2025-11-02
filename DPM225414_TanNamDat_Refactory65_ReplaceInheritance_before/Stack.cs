using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory65_ReplaceInheritance_before
{
    internal class Stack<T> : Vector<T>
    {
        public void Push(T item)
        {
            Add(item);  
        }

        public T Pop()
        {
            return RemoveLast();
        }
    }
}
