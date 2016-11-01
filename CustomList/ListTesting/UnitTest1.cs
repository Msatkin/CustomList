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
            ListCustom<int> testListOne = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);

            Assert.AreEqual(1, testListOne.ReturnAt(1));
        }
        [TestMethod]
        public void AddAtIndex()
        {
            ListCustom<int> testListOne = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(3);
            testListOne.Add(4);
            testListOne.Add(5);
            testListOne.AddAt(6, 0);

            Assert.AreEqual(5, testListOne.ReturnAt(6));
        }
        [TestMethod]
        public void RemoveItem()
        {
            ListCustom<int> testListOne = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Remove(1);

            Assert.AreEqual(2, testListOne.ReturnAt(1));
        }
        [TestMethod]
        public void RemoveAtIndex()
        {
            ListCustom<int> testListOne = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.RemoveAt(1);

            Assert.AreEqual(2, testListOne.ReturnAt(1));
        }
        [TestMethod]
        public void CountItem()
        {
            ListCustom<int> testListOne = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);
            testListOne.Add(1);
            testListOne.Add(1);
            testListOne.Add(2);

            Assert.AreEqual(3, testListOne.Count(1));
        }
        [TestMethod]
        public void CountAll()
        {
            ListCustom<int> testListOne = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(1);
            testListOne.Add(2);

            Assert.AreEqual(5, testListOne.Count());
        }
        [TestMethod]
        public void ConvertToString()
        {
            ListCustom<string> testListOne = new ListCustom<string>();

            testListOne.Add("Hello");
            testListOne.Add(" ");
            testListOne.Add("World");

            Assert.AreEqual("Hello World", testListOne.ToString());
        }
        [TestMethod]
        public void ZipperTwoLists()
        {
            ListCustom<int> testListOne = new ListCustom<int>();
            ListCustom<int> testListTwo = new ListCustom<int>();
            ListCustom<int> results = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(2);
            testListOne.Add(4);
            testListOne.Add(6);
            testListOne.Add(8);
            testListOne.Add(10);
            testListOne.Add(11);
            testListOne.Add(12);
            testListOne.Add(13);
            testListOne.Add(14);
            testListTwo.Add(1);
            testListTwo.Add(3);
            testListTwo.Add(5);
            testListTwo.Add(7);
            testListTwo.Add(9);
            results = testListOne.Zipper(testListOne, testListTwo);

            Assert.AreEqual(5, results.ReturnAt(5));
        }
        [TestMethod]
        public void AddTwoLists()
        {
            ListCustom<int> testListOne = new ListCustom<int>();
            ListCustom<int> testListTwo = new ListCustom<int>();
            ListCustom<int> results = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(3);
            testListOne.Add(4);
            testListOne.Add(5);
            testListOne.Add(6);
            testListOne.Add(7);
            testListOne.Add(8);
            testListOne.Add(9);
            testListTwo.Add(1);
            testListTwo.Add(3);
            testListTwo.Add(5);
            testListTwo.Add(7);
            testListTwo.Add(9);

            results = testListOne + testListTwo;

            Assert.AreEqual(7, results.ReturnAt(13));
        }
        [TestMethod]
        public void SubtractTwoLists()
        {
            ListCustom<int> testListOne = new ListCustom<int>();
            ListCustom<int> testListTwo = new ListCustom<int>();
            ListCustom<int> results = new ListCustom<int>();

            testListOne.Add(0);
            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(3);
            testListOne.Add(4);
            testListOne.Add(5);
            testListOne.Add(6);
            testListOne.Add(7);
            testListOne.Add(8);
            testListOne.Add(9);
            testListTwo.Add(1);
            testListTwo.Add(3);
            testListTwo.Add(5);
            testListTwo.Add(7);
            testListTwo.Add(9);

            results = testListOne - testListTwo;
            Assert.AreEqual(8, results.ReturnAt(4));
        }
    }
}
