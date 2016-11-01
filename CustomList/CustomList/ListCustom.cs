using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ListCustom<T>
    {
        public int count = 0;
        public int capacity = 4;
        private int capacityInterval = 2;
        public Int32 item;
        private T[] list;

        public ListCustom()
        {
            list = new T[capacity];
        }
        public void Add(T addition)
        {
            capacity += capacityInterval;
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
            capacity -= capacityInterval;
            T[] tempList = new T[capacity];
            for (int i = 0; i < count + 1; i++)
            {
                if (list[i].Equals(removal))
                {
                    if (list[i + itemsRemoved + 1] != null)
                    {
                        itemsRemoved++;
                        tempList[i] = list[i + itemsRemoved];
                    }
                }
                else
                {
                    tempList[i] = list[i + itemsRemoved];
                }
            }
            count -= itemsRemoved;
            list = tempList;
        }
        public int Count()
        {
            return count;
        }
        public T ReturnAt(Int32 index)
        {
            if (index < count)
            {
                return list[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
