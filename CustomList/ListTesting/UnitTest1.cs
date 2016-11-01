using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddItem()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);

            Assert.AreEqual(1, testList.ReturnAt(1));
        }
        [TestMethod]
        public void AddAtIndex()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.AddAt(6, 0);

            Assert.AreEqual(5, testList.ReturnAt(6));
        }
        [TestMethod]
        public void RemoveItem()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Remove(1);

            Assert.AreEqual(2, testList.ReturnAt(1));
        }
        [TestMethod]
        public void RemoveAtIndex()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.RemoveAt(1);

            Assert.AreEqual(2, testList.ReturnAt(1));
        }
        [TestMethod]
        public void CountItem()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(2);

            Assert.AreEqual(3, testList.Count(1));
        }
        [TestMethod]
        public void CountAll()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Add(1);
            testList.Add(2);

            Assert.AreEqual(5, testList.Count());
        }
        [TestMethod]
        public void ConvertToString()
        {
            ListCustom<string> testList = new ListCustom<string>();

            testList.Add("Hello");
            testList.Add(" ");
            testList.Add("World");

            Assert.AreEqual("Hello World", testList.ToString());
        }
        [TestMethod]
        public void ZipperTwoLists()
        {
            ListCustom<int> testList = new ListCustom<int>();
            ListCustom<int> testList2 = new ListCustom<int>();

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

            Assert.AreEqual(5, testList.ReturnAt(5));
        }
        [TestMethod]
        public void AddTwoLists()
        {
            ListCustom<int> testList = new ListCustom<int>();
            ListCustom<int> testList2 = new ListCustom<int>();
            ListCustom<int> results = new ListCustom<int>();

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

            results = testList + testList2;

            Assert.AreEqual(7, results.ReturnAt(13));
        }
        [TestMethod]
        public void SubtractTwoLists()
        {
            ListCustom<int> testList = new ListCustom<int>();
            ListCustom<int> testList2 = new ListCustom<int>();
            ListCustom<int> results = new ListCustom<int>();

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
            Assert.AreEqual(8, results.ReturnAt(4));
        }
    }
}
