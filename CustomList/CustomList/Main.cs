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
        ListCustom<int> results = new ListCustom<int>();

        public void RunTest()
        {
            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            testList2.Add(1);
            testList2.Add(3);
            testList2.Add(5);
            testList2.Add(7);
            testList2.Add(9);

            results = testList - testList2;
            PrintList();
        }
        public void PrintList()
        {
            Console.Clear();
            for (int i = 0; i < testList.Count(); i++)
            {
                Console.WriteLine(results.ReturnAt(i));
            }
            Console.ReadLine();
        }
    }
}
