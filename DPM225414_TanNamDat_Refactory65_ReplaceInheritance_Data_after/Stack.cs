using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory65_ReplaceInheritance_Data_after
{
    public class Stack<T>
    {
        private Vector<T> _vector = new Vector<T>();

        public bool IsEmpty()
        {
            // Ủy quyền lại cho Vector
            return _vector.IsEmpty();
        }

        public void Push(T item)
        {
            _vector.Add(item);
        }

        public T Pop()
        {
            return _vector.RemoveLast();
        }
    }
}
