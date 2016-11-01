using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class ListCustom<T>
    {
        public int count = 0;
        public int capacity = 16;
        public Int32 item;
        private T[] list;

        public ListCustom()
        {
            list = new T[16];
        }
        public void Add(T addition)
        {
            capacity += 2;
            T[] tempList = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                tempList[i] = list[i];
            }
            tempList[count] = addition;
            count++;
            list = tempList;
        }
        public void Remove(T removal)
        {
            int itemsRemoved = 0;
            capacity -= 2;
            T[] tempList = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(removal))
                {
                    if (list[i + itemsRemoved + 1] != null)
                    {
                        itemsRemoved++;
                        tempList[i] = list[i + itemsRemoved + 1];
                    }
                }
            }
            count--;
            list = tempList;
        }
        public int Count()
        {
            return count;
        }
    }
}
