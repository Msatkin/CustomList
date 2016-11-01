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

            Assert.AreEqual(2,testList.ReturnAt(1));
        }
    }
}
