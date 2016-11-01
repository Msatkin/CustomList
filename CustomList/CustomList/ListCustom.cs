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
        int count = 0;
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
        //-----------------------------------------Misc
        public int Count()
        {
            return count;
        }
        public int Count(T item)
        {
            int amountOfItem = 0;
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(item))
                {
                    amountOfItem++;
                }
            }
            return amountOfItem;
        }
        public int GetFirstIndex(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(item))
                {
                    return i;
                }
            }
            throw new NullReferenceException();
        }
        public override string ToString()
        {
            StringBuilder listString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                 listString.Append(list[i]);
            }
            return listString.ToString();
        }
        public void Zipper(ListCustom<T> list2)
        {
            T[] tempList = new T[capacity + list2.capacity];
            int length = GetLesserLength(list2);
            for (int i = 0; i < length; i++)
            {
                tempList[(i * 2)] = list[i];
                tempList[(i * 2) + 1] = list2.list[i];
            }
            if (ListTwoSmaller(list2))
            {
                for (int i = list2.count * 2; i < count + list2.count; i++)
                {
                    tempList[i] = list[i - list2.count];
                }
            }
            else
            {
                for (int i = count * 2; i < count + list2.count; i++)
                {
                    tempList[i] = list2.list[i - count];
                }
            }
            list = tempList;
            count += list2.count;
            capacity += list2.capacity;
        }
        private int GetLesserLength(ListCustom<T> list2)
        {
            if (count <= list2.count)
            {
                return count;
            }
            else
            {
                return list2.count;
            }
        }
        private bool ListTwoSmaller(ListCustom<T> list2)
        {
            if (count <= list2.count)
            {
                return false;
            }
            else
            {
                return true;
            }
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