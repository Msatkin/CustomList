using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddItemInt()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>();
            //Act
            testListOne.Add(0);
            testListOne.Add(1);
            //Assert
            Assert.AreEqual(0, testListOne[0]);
            Assert.AreEqual(1, testListOne[1]);
        }
        [TestMethod]
        public void AddItemString()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>();
            //Act
            testListOne.Add("Hello");
            testListOne.Add("World");
            //Assert
            Assert.AreEqual("Hello", testListOne[0]);
            Assert.AreEqual("World", testListOne[1]);
        }
        [TestMethod]
        public void AddItemObject()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>();
            //Act
            testListOne.Add(new Person("1"));
            testListOne.Add(new Person("2"));
            //Assert
            Assert.AreEqual("1", testListOne[0].name);
            Assert.AreEqual("2", testListOne[1].name);
        }
        [TestMethod]
        public void AddAtInt()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 1, 2 };
            //Act
            testListOne.AddAt(3, 0);
            //Assert
            Assert.AreEqual(3, testListOne[0]);
        }
        [TestMethod]
        public void AddAtString()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "Hello", "World"};
            //Act
            testListOne.AddAt(" ", 1);
            //Assert
            Assert.AreEqual("Hello", testListOne[0]);
            Assert.AreEqual(" ", testListOne[1]);
            Assert.AreEqual("World", testListOne[2]);
        }
        [TestMethod]
        public void AddAtObject()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("1"), new Person("3") };
            //Act
            testListOne.AddAt(new Person("2"),1);
            //Assert
            Assert.AreEqual("1", testListOne[0].name);
            Assert.AreEqual("2", testListOne[1].name);
            Assert.AreEqual("3", testListOne[2].name);
        }
        [TestMethod]
        public void RemoveInt()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 1, 2 };
            //Act
            testListOne.Remove(1);
            //Assert
            Assert.AreEqual(0, testListOne[0]);
            Assert.AreEqual(2, testListOne[1]);
        }
        [TestMethod]
        public void RemoveString()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "Hello", "fail", "world" };
            //Act
            testListOne.Remove("fail");
            //Assert
            Assert.AreEqual("Hello", testListOne[0]);
            Assert.AreEqual("world", testListOne[1]);
        }
        [TestMethod]
        public void RemoveObject()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("1"), new Person("3"), new Person("2")};
            //Act
            testListOne.Remove(testListOne[1]);
            //Assert
            Assert.AreEqual("1", testListOne[0].name);
            Assert.AreEqual("2", testListOne[1].name);
        }
        [TestMethod]
        public void RemoveIntAtIndex()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 1, 2 };
            //Act
            testListOne.RemoveAt(1);
            //Assert
            Assert.AreEqual(0, testListOne[0]);
            Assert.AreEqual(2, testListOne[1]);
        }
        [TestMethod]
        public void RemoveStringAtIndex()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "0", "1", "2" };
            //Act
            testListOne.RemoveAt(1);
            //Assert
            Assert.AreEqual("0", testListOne[0]);
            Assert.AreEqual("2", testListOne[1]);
        }
        [TestMethod]
        public void RemoveObjectAtIndex()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("1"), new Person("3"), new Person("2") };
            //Act
            testListOne.RemoveAt(1);
            //Assert
            Assert.AreEqual("1", testListOne[0].name);
            Assert.AreEqual("2", testListOne[1].name);
        }
        [TestMethod]
        public void CountItemInt()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 1, 1, 1, 2 };
            //Act
            int result = testListOne.Count(1);
            //Assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void CountItemString()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "0", "1", "1", "1", "2" };
            //Act
            int result = testListOne.Count("1");
            //Assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void CountItemObject()
        {
            //Arrange
            Person test = new Person("test");
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("1"), test, test, test, new Person("2") };
            //Act
            int result = testListOne.Count(test);
            //Assert
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void CountAllInt()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 1, 1, 1, 2 };
            //Act
            int result = testListOne.Count();
            //Assert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void CountAllString()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "0", "1", "1", "1", "2" };
            //Act
            int result = testListOne.Count();
            //Assert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void CountAllObject()
        {
            //Arrange
            Person test = new Person("test");
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("1"), test, test, test, new Person("2") };
            //Act
            int result = testListOne.Count();
            //Assert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void ConvertToStringInt()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 1, 2, 3 };
            //Act
            string result = testListOne.ToString();
            //Assert
            Assert.AreEqual("123", result);
        }
        [TestMethod]
        public void ConvertToStringString()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "1", "2", "3" };
            //Act
            string result = testListOne.ToString();
            //Assert
            Assert.AreEqual("123", result);
        }
        [TestMethod]
        public void ConvertToStringObject()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("1"), new Person("1"), new Person("1") };
            //Act
            string result = testListOne.ToString();
            //Assert
            Assert.AreEqual("CustomList.PersonCustomList.PersonCustomList.Person", result);
        }
        [TestMethod]
        public void ZipperTwoIntLists()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 2, 4, 6};
            ListCustom<int> testListTwo = new ListCustom<int>() { 1, 3, 5 };
            //Act
            ListCustom<int> results = testListOne.Zipper(testListOne, testListTwo);
            //Assert
            Assert.AreEqual(0, results[0]);
            Assert.AreEqual(1, results[1]);
            Assert.AreEqual(2, results[2]);
            Assert.AreEqual(3, results[3]);
            Assert.AreEqual(4, results[4]);
            Assert.AreEqual(5, results[5]);
        }
        [TestMethod]
        public void ZipperTwoStringLists()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "0", "2", "4", "6" };
            ListCustom<string> testListTwo = new ListCustom<string>() { "1", "3", "5" };
            //Act
            ListCustom<string> results = testListOne.Zipper(testListOne, testListTwo);
            //Assert
            Assert.AreEqual("0", results[0]);
            Assert.AreEqual("1", results[1]);
            Assert.AreEqual("2", results[2]);
            Assert.AreEqual("3", results[3]);
            Assert.AreEqual("4", results[4]);
            Assert.AreEqual("5", results[5]);
        }
        [TestMethod]
        public void ZipperTwoObjectLists()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("test"), new Person("test"), new Person("test"), new Person("test") };
            ListCustom<Person> testListTwo = new ListCustom<Person>() { new Person("test"), new Person("test"), new Person("test") };
            //Act
            ListCustom<Person> results = testListOne.Zipper(testListOne, testListTwo);
            //Assert
            Assert.AreEqual(testListOne[0], results[0]);
            Assert.AreEqual(testListTwo[0], results[1]);
            Assert.AreEqual(testListOne[1], results[2]);
            Assert.AreEqual(testListTwo[1], results[3]);
            Assert.AreEqual(testListOne[2], results[4]);
            Assert.AreEqual(testListTwo[2], results[5]);
        }
        [TestMethod]
        public void AddTwoIntLists()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 1, 2 };
            ListCustom<int> testListTwo = new ListCustom<int>() { 3, 4, 5 };
            //Act
            ListCustom<int> results = testListOne + testListTwo;
            //Assert
            Assert.AreEqual(0, results[0]);
            Assert.AreEqual(1, results[1]);
            Assert.AreEqual(2, results[2]);
            Assert.AreEqual(3, results[3]);
            Assert.AreEqual(4, results[4]);
            Assert.AreEqual(5, results[5]);
        }
        [TestMethod]
        public void AddTwoStringLists()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "0", "1", "2" };
            ListCustom<string> testListTwo = new ListCustom<string>() { "3", "4", "5" };
            //Act
            ListCustom<string> results = testListOne + testListTwo;
            //Assert
            Assert.AreEqual("0", results[0]);
            Assert.AreEqual("1", results[1]);
            Assert.AreEqual("2", results[2]);
            Assert.AreEqual("3", results[3]);
            Assert.AreEqual("4", results[4]);
            Assert.AreEqual("5", results[5]);
        }
        [TestMethod]
        public void AddTwoObjectLists()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("test"), new Person("test"), new Person("test") };
            ListCustom<Person> testListTwo = new ListCustom<Person>() { new Person("test"), new Person("test"), new Person("test") };
            //Act
            ListCustom<Person> results = testListOne + testListTwo;
            //Assert
            Assert.AreEqual(testListOne[0], results[0]);
            Assert.AreEqual(testListOne[1], results[1]);
            Assert.AreEqual(testListOne[2], results[2]);
            Assert.AreEqual(testListTwo[0], results[3]);
            Assert.AreEqual(testListTwo[1], results[4]);
            Assert.AreEqual(testListTwo[2], results[5]);
        }
        [TestMethod]
        public void SubtractTwoIntLists()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 0, 0, 0, 1, 1, 1, 2, 2, 3, 4 };
            ListCustom<int> testListTwo = new ListCustom<int>() { 0, 1, 2 };
            //Act
            ListCustom<int> results = testListOne - testListTwo;
            //Assert
            Assert.AreEqual(3, results[0]);
            Assert.AreEqual(4, results[1]);
        }
        [TestMethod]
        public void SubtractTwoStringLists()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "0", "0", "0", "1", "1", "1", "2", "2", "3", "4" };
            ListCustom<string> testListTwo = new ListCustom<string>() { "0", "1", "2" };
            //Act
            ListCustom<string> results = testListOne - testListTwo;
            //Assert
            Assert.AreEqual("3", results[0]);
            Assert.AreEqual("4", results[1]);
        }
        [TestMethod]
        public void SubtractTwoObjectLists()
        {
            //Arrange
            Person testOne = new Person("test1");
            Person testTwo = new Person("test2");
            Person testThree = new Person("test3");
            ListCustom<Person> testListOne = new ListCustom<Person>() { testOne, testOne, testOne, testTwo, testTwo, testThree };
            ListCustom<Person> testListTwo = new ListCustom<Person>() { testOne, testTwo };
            //Act
            ListCustom<Person> results = testListOne - testListTwo;
            //Assert
            Assert.AreEqual(testThree, results[0]);
        }
        [TestMethod]
        public void SortIntList()
        {
            //Arrange
            ListCustom<int> testListOne = new ListCustom<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //Act
            testListOne.Sort();
            //Assert
            Assert.AreEqual(0, testListOne[0]);
            Assert.AreEqual(1, testListOne[1]);
            Assert.AreEqual(2, testListOne[2]);
            Assert.AreEqual(3, testListOne[3]);
            Assert.AreEqual(4, testListOne[4]);
            Assert.AreEqual(5, testListOne[5]);
            Assert.AreEqual(6, testListOne[6]);
            Assert.AreEqual(7, testListOne[7]);
            Assert.AreEqual(8, testListOne[8]);
            Assert.AreEqual(9, testListOne[9]);
        }
        [TestMethod]
        public void SortStringList()
        {
            //Arrange
            ListCustom<string> testListOne = new ListCustom<string>() { "v", "y", "x", "w", "z", "u", "t", "s", "r", "q" };
            //Act
            testListOne.Sort();
            //Assert
            Assert.AreEqual("q", testListOne[0]);
            Assert.AreEqual("r", testListOne[1]);
            Assert.AreEqual("s", testListOne[2]);
            Assert.AreEqual("t", testListOne[3]);
            Assert.AreEqual("u", testListOne[4]);
            Assert.AreEqual("v", testListOne[5]);
            Assert.AreEqual("w", testListOne[6]);
            Assert.AreEqual("x", testListOne[7]);
            Assert.AreEqual("y", testListOne[8]);
            Assert.AreEqual("z", testListOne[9]);
        }
        [TestMethod]
        public void SortObjectList()
        {
            //Arrange
            ListCustom<Person> testListOne = new ListCustom<Person>() { new Person("z"), new Person("x"), new Person("w"), new Person("a"), };
            //Act
            testListOne.Sort();
            //Arrange
            Assert.AreEqual("a", testListOne[0].name);
            Assert.AreEqual("w", testListOne[1].name);
            Assert.AreEqual("x", testListOne[2].name);
            Assert.AreEqual("z", testListOne[3].name);
        }
    }
}
