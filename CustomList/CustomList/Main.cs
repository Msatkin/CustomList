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
        ListCustom<int> testList2 = new ListCustom<int>();

        public void RunTest()
        {
            testList.Add(0);
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);
            testList.Add(10);
            testList.Add(11);
            testList.Add(12);
            testList.Add(13);
            testList.Add(14);
            testList2.Add(1);
            testList2.Add(3);
            testList2.Add(5);
            testList2.Add(7);
            testList2.Add(9);
            testList.Zipper(testList2);
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
