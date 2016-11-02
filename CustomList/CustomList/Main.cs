using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Main
    {
        ListCustom<string> testListOne = new ListCustom<string>();
        ListCustom<int> testList2 = new ListCustom<int>();
        ListCustom<string> results = new ListCustom<string>();

        public void RunTest()
        {
            results = testListOne;
            PrintList();
        }
        public void PrintList()
        {
            Console.Clear();
            for (int i = 0; i < results.Count(); i++)
            {
                Console.WriteLine(results[i]);
            }
            Console.ReadLine();
        }
    }
}
