using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program
{
    [TestClass]
    public class CustomListTest
    {
        [TestClass]
        class Test
        {
            [TestMethod]
            public void AddTest()
            {
                //arrange
                CustomList<int> list = new CustomList<int>();
                int expectedResult = 0;
                //assert
                list.Add(0);
                int result = list[0];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            public void AddTestResultIndex2()
            {
                //arrange
                CustomList<int> list = new CustomList<int>();
                int expectedResult = 0;
                //assert
                list.Add(2);
                list.Add(1);
                list.Add(0);
                int result = list[2];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            public void AddTestInLoop()
            {
                //arrange
                CustomList<int> list = new CustomList<int>();
                int expectedResult = 5;
                //assert
                for (int i = 0; i < 5; i++)
                {
                    list.Add(i);
                }
                int result = list[4];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void AddTestStrings()
            {
                //arrange
                CustomList<string> list = new CustomList<string>();
                string expectedResult = "World";
                //assert
                list.Add("Hello");
                list.Add("World");
                string result = list[1];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void AddAndRemoveTest()
            {
                //arrange
                CustomList<int> list = new CustomList<int>();
                int expectedResult = 2;
                //assert
                list.Add(0);
                list.Add(1);
                list.Add(2);
                list.Remove(0);
                int result = list[1];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void RemoveTestInts()
            {
                //arrange
                CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
                int expectedResult = 3;
                //assert
                list.Remove(1);
                list.Remove(2);
                int result = list[0];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void RemoveTestChars()
            {
                //arrange
                CustomList<char> list = new CustomList<char>() { 'a', 'b', 'c' };
                char expectedResult = 'c';
                //assert
                list.Remove('a');
                list.Remove('b');
                char result = list[0];
                //act
                Assert.AreEqual(result, expectedResult);    
            }
            [TestMethod]
            public void RemoveTestStrings()
            {
                //arrange
                //List<int> list = new List<int>(new int[] { 2, 3, 7 });
                CustomList<string> list = new CustomList<string>() { "Hello", "World", "!!!" };
                string expectedResult = "World";
                //assert
                list.Remove("Hello");
                list.Remove("!!!");
                string result = list[0];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void AddRemoveTest()
            {
                //arrange
                CustomList<int> list = new CustomList<int>();
                int expectedResult = 9;
                //assert
                list.Add(1);
                list.Add(3);
                list.Add(5);
                list.Add(7);
                list.Add(9);
                list.Remove(1);
                list.Remove(3);
                list.Remove(5);
                int result = list[1];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void ZipTestInts()
            {
                CustomList<int> odds = new CustomList<int>() { 1, 3, 5 };
                CustomList<int> evens = new CustomList<int>() { 2, 4, 6 };
                CustomList<int> expectedResult = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

                odds.Zip(evens);
                CustomList<int> result = odds;
                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ZipTestChars()
            {
                CustomList<char> ace = new CustomList<char>() { 'a', 'c', 'e' };
                CustomList<char> bdf = new CustomList<char>() { 'b', 'd', 'f' };
                CustomList<int> expectedResult = new CustomList<int> { 'a', 'b', 'c', 'd', 'e', 'f' };

                ace.Zip(bdf);
                CustomList<char> result = ace;
                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ZipTestStrings()
            {

                CustomList<string> list1 = new CustomList<string>() { "This", "is", "CustomList" };
                CustomList<string> list2 = new CustomList<string>() { "class", "called" };
                CustomList<string> expectedResult = new CustomList<string>() { "This", "class", "is", "called", "CustomList" };

                list1.Zip(list2);
                CustomList<string> result = list1;

                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ToStringTestInts()
            {
                CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
                string expectedResult = "12345";

                string result = list.ToString();

                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void ToStringTestChars()
            {
                CustomList<char> list = new CustomList<char>() { 'H', 'e', 'l', 'l', 'o' };
                string expectedResult = "Hello";

                string result = list.ToString();

                Assert.AreEqual(result, expectedResult);
            }
        }
    }
}
