using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Task
{
    internal class CustomList<T>
    {
        private T[] _list;
        private int count;
        private int capasity;
        private int initalizeNum = 4;
        public int Count { get=>count;  }
        public int Capasity { get=>capasity; }
        public CustomList()
        {
            _list = new T[0];
            capasity=_list.Length;
        }
        public void Add(T item)
        {
            if (count==capasity)
            {
                Array.Resize(ref _list,capasity==0? initalizeNum : _list.Length*2);
                capasity = _list.Length;
            }
            _list[count] = item;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{item} added \n -----------");
            Console.ResetColor();
            count++;
        }
        public void GetAll()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(_list[i]);
            }
          
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_list, item);
            if (index != -1)
            {
                for (int i = index; i < count; i++)
                {
                    _list[i] = _list[i + 1];
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{item} Removed \n -----------");
                Console.ResetColor();
                count--;
            }
            else {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{item} not found . May have been deleted before  \n ------------------------------------------");
                Console.ResetColor();
            }
        }

        public bool Contains(T item) 
        {
          int itemIndex=Array.IndexOf(_list, item);
            if (itemIndex != -1)
            {
                return true;
            }
            return false;
        }

       public bool Any()
        {
            if (count>0)
            {
              return true;

            }
            return false;
        }
        public void Clear()
        {
            //for (int i = 0; i < count; i++)
            //{
            //    _list[i] = default;
            //} 
            //yaxud

            int index =0;
            while (index < count)
            {
                _list[index] = default;
                index++;
            }
            count = 0;
        }

        public T FirstOrDefault()
        {
            if (Any())
            {
                return _list[0];
            }
            return default;
        }
        public T ElementAtOrDefault(int i)
        {
            if (i>=0 && i<count)
            {
                return _list[i];
            }
            return default;
        }

        public T LastOrDefault()
        {
            if (Any())
            {
                return _list[count-1]; 
            }
            return default;
        }
    }
}
