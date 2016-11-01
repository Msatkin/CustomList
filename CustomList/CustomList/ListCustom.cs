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
        private T[] list;

        public ListCustom()
        {
            list = new T[capacity];
        }
        //-----------------------------------------Add
        public void Add(T item)
        {
            capacity += capacityInterval;
            T[] tempList = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                tempList[i] = list[i];
            }
            tempList[count] = item;
            count++;
            list = tempList;
        }
        public void AddAt(T item, int index)
        {
            capacity += capacityInterval;
            T[] tempList = new T[capacity];
            for (int i = 0; i < index; i++)
            {
                tempList[i] = list[i];
            }
            tempList[index] = item;
            count++;
            for (int i = index + 1; i < count; i++)
            {
                tempList[i] = list[i - 1];
            }
            list = tempList;
        }
        //-----------------------------------------Remove
        public void Remove(T item)
        {
            int itemsRemoved = 0;
            capacity -= capacityInterval;
            T[] tempList = new T[capacity];
            for (int i = 0; i < count + 1; i++)
            {
                if (list[i].Equals(item))
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
        public void RemoveAt(int index)
        {
            capacity -= capacityInterval;
            T[] tempList = new T[capacity];
            for (int i = 0; i < index; i++)
            {
                tempList[i] = list[i];
            }
            
            for (int i = index; i < count + 1; i++)
            {
                tempList[i] = list[i + 1];
            }
            count--;
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
