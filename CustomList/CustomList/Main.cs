using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Main
    {
        ListCustom<int> testList = new ListCustom<int>();
        List<int> testList2 = new List<int>() { 1, 1, 1, 2, 2, 2 };

        public void RunTest()
        {
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(3);
            testList.Add(2);
            testList.Add(1);
            PrintList();
            testList.Remove(1);
            PrintList();
            testList.Remove(2);
            PrintList();
            testList.Remove(3);
            PrintList();
        }
        public void PrintList()
        {
            Console.Clear();
            for (int i = 0; i < testList.Count(); i++)
            {
                Console.WriteLine(testList.ReturnAt(i));
            }
            Console.ReadLine();
        }
    }
}
