using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ListCustom<T> : CollectionBase, IEnumerable where T : IComparable<T>
    {
        private int count = 0;
        private static int listBuffer = 8;
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
            int numberOfItems = Count(item);
            while (Count(item) > 0)
            {
                int index = GetFirstIndex(item);
                RemoveAt(index);
            }
        }
        new public void RemoveAt(int index)
        {
            int removed = 0;
            T[] tempList = new T[count + listBuffer - 1];
            for (int i = 0; i < count; i++)
            {
                if (i != index)
                {
                    tempList[i - removed] = list[i];
                }
                else
                {
                    removed++;
                }
            }
            count -= removed;
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
            return -1;
        }
        private int GetLesserLength(ListCustom<T> listOne, ListCustom<T> listTwo)
        {
            return Math.Min(listOne.Count(), listTwo.Count());
        }
        public T ReturnAt(int index)
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
                for (int i = 0; i < listOne.Count(); i++)
                {
                    tempList.Add(listOne[i]);
                }
                for (int i = 0; i < listTwo.Count(); i++)
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
            ListCustom<T> listThree = listOne;
            if (listOne != null && listTwo != null)
            {
                for (int i = 0; i < listTwo.Count(); i++)
                {
                    listThree.Remove(listTwo.list[i]);
                }
                return listThree;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        //-----------------------------------------Sorting
        public void Sort()
        {
            QuickSort(list, 0, count - 1);
        }
        private void QuickSort<T>(T[] list, int left, int right) where T : IComparable<T>
        {
            int i = left;
            int j = right;
            T pivot = list[(left + right) / 2];
            while (i <= j)
            {
                while(list[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (list[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    T temp = list[i];
                    list[i++] = list[j];
                    list[j--] = temp;
                }
            }
            if (left < j)
            {
                QuickSort(list, left, j);
            }
            if (i < right)
            {
                QuickSort(list, i, right);
            }
        }
        private int CompareTo(T y)
        {
            return this.CompareTo(y);
        }
    }
}