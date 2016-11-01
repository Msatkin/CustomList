using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddItemToList()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);

            Assert.AreEqual(testList.ReturnAt(1), 1);
        }
        [TestMethod]
        public void RemoveItemFromList()
        {
            ListCustom<int> testList = new ListCustom<int>();

            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Remove(1);

            Assert.AreEqual(testList.ReturnAt(1), 2);
        }
    }
}
