using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory65_ReplaceInheritance_Data_after
{
    public class Vector<T>
    {
        private List<T> _items = new List<T>();

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T RemoveLast()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Vector is empty!");
            var last = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return last;
        }
    }
}
