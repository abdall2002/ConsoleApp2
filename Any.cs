using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    class Any<T>
    {
        private T[] _item;


        public void Add(T item)
        {
            if(_item == null)
            {
                _item = new T[] {item};
            }
            else
            {
                var length = _item.Length;
                var dest = new T[length + 1]; 
                for(int i = 0; i < length; i++) 
                {
                    dest[i] = _item[i]; 
                }
                dest[dest.Length - 1] = item;
                _item = dest;
            }
        }

        public void RemoveAt(int position)
        {
            if(position < 0 || position > _item.Length - 1)
            {
                return; 
            }

            var index = 0;
            var dest = new T[_item.Length - 1];
            for (int i = 0; i < _item.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++] = _item[i];   
            }
            _item = dest;
        }

        public void DisplayList()
        {
            Console.Write("[");
            for (int i = 0; i < _item.Length; i++)
            {
                Console.Write(_item[i]);
                if(i < _item.Length -1) 
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
        }

        public bool IsEmpty => _item is null || _item.Length == 0;

        public int Count => _item is null ? 0 : _item.Length; 
        
    }
}
