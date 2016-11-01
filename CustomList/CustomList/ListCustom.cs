using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ListCustom<T> : CollectionBase, IEnumerable
    {
        int count = 0;
        static int listBuffer = 8;
        private T[] list;

        public T this[int index]
        {
            get
            {
                return (T) this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }
        public ListCustom()
        {
            list = new T[count + listBuffer];
        }
        //-----------------------------------------Add
        public void Add(T item)
        {
            T[] tempList = new T[count + listBuffer];
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
            T[] tempList = new T[count + listBuffer];
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
            T[] tempList = new T[count + listBuffer];
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
        new public void RemoveAt(int index)
        {
            T[] tempList = new T[count + listBuffer];
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
        public ListCustom<T> Zipper(ListCustom<T> listOne, ListCustom<T> listTwo)
        {
            if (listOne != null && listTwo != null)
            {
                ListCustom<T> tempList = new ListCustom<T>();
                int length = GetLesserLength(listOne, listTwo);
                for (int i = 0; i < length; i++)
                {
                    tempList.Add(listOne[i]);
                    tempList.Add(listTwo[i]);
                }
                return tempList;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        new public int Count()
        {
            return count;
        }
        new public int Count(T item)
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
        private int GetLesserLength(ListCustom<T> listOne, ListCustom<T> listTwo)
        {
            if (listOne.count <= listTwo.count)
            {
                return count;
            }
            else
            {
                return listTwo.count;
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
        new public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return list[i];
            }
        }
        //-----------------------------------------Overrides
        public override string ToString()
        {
            StringBuilder listString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                    listString.Append(list[i]);
            }
            return listString.ToString();
        }
        //-----------------------------------------Overloads
        public static ListCustom<T> operator +(ListCustom<T> listOne, ListCustom<T> listTwo)
        {
            if (listOne != null && listTwo != null)
            {
                ListCustom<T> tempList = new ListCustom<T>();
                for (int i = 0; i < listOne.count; i++)
                {
                    tempList.Add(listOne[i]);
                }
                for (int i = 0; i < listTwo.count; i++)
                {
                    tempList.Add(listTwo[i]);
                }
                return tempList;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public static ListCustom<T> operator -(ListCustom<T> listOne, ListCustom<T> listTwo)
        {
            if (listOne != null && listTwo != null)
            {
                for (int i = 0; i < listTwo.count; i++)
                {
                    listOne.Remove(listTwo.list[i]);
                }
                return listOne;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}