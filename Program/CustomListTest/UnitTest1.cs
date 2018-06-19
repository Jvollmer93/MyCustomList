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
            [TestMethod]
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
            [TestMethod]
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
                CustomList<int> list = new CustomList<int>();//{ 1, 2, 3 }
                int expectedResult = 3;
                //assert
                list.Add(1);
                list.Add(2);
                list.Add(3);
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
                CustomList<char> list = new CustomList<char>();// { 'a', 'b', 'c' }
                char expectedResult = 'c';
                //assert
                list.Add('a');
                list.Add('b');
                list.Add('c');
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
                CustomList<string> list = new CustomList<string>();// { "Hello", "World", "!!!" }
                string expectedResult = "World";
                //assert
                list.Add("Hello");
                list.Add("World");
                list.Add("!!!");
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
                CustomList<int> odds = new CustomList<int>();// { 1, 3, 5 }
                CustomList<int> evens = new CustomList<int>();// { 2, 4, 6 }
                CustomList<int> expectedResult = new CustomList<int>();// { 1, 2, 3, 4, 5, 6 };

                odds.Add(1);
                odds.Add(3);
                odds.Add(5);
                evens.Add(2);
                evens.Add(4);
                evens.Add(6);
                expectedResult.Add(1);
                expectedResult.Add(2);
                expectedResult.Add(3);
                expectedResult.Add(4);
                expectedResult.Add(5);
                expectedResult.Add(6);

                //odds.Zip(evens);
                CustomList<int> result = odds;
                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ZipTestChars()
            {
                CustomList<char> ace = new CustomList<char>();// { 'a', 'c', 'e' }
                CustomList<char> bdf = new CustomList<char>();// { 'b', 'd', 'f' }
                CustomList<char> expectedResult = new CustomList<char>();// { 'a', 'b', 'c', 'd', 'e', 'f' }

                ace.Add('a');
                ace.Add('c');
                ace.Add('e');
                bdf.Add('b');
                bdf.Add('d');
                bdf.Add('f');
                expectedResult.Add('a');
                expectedResult.Add('b');
                expectedResult.Add('c');
                expectedResult.Add('d');
                expectedResult.Add('e');
                expectedResult.Add('f');

                //ace.Zip(bdf);
                CustomList<char> result = ace;

                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ZipTestStrings()
            {

                CustomList<string> list1 = new CustomList<string>();// { "This", "is", "CustomList" }
                CustomList<string> list2 = new CustomList<string>();// { "class", "called" }
                CustomList<string> expectedResult = new CustomList<string>();// { "This", "class", "is", "called", "CustomList" }
                
                list1.Add("This");
                list1.Add("is");
                list1.Add("CustmoList");
                list2.Add("class");
                list2.Add("called");
                expectedResult.Add("This");
                expectedResult.Add("class");
                expectedResult.Add("is");
                expectedResult.Add("called");
                expectedResult.Add("CustomList");
                
                //list1.Zip(list2);
                CustomList<string> result = list1;

                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ToStringTestInts()
            {
                CustomList<int> list = new CustomList<int>();// { 1, 2, 3, 4, 5 }
                string expectedResult = "12345";

                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(4);
                list.Add(5);

                string result = list.ToString();

                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void ToStringTestChars()
            {
                CustomList<char> list = new CustomList<char>();// { 'H', 'e', 'l', 'l', 'o' };
                string expectedResult = "Hello";

                list.Add('H');
                list.Add('e');
                list.Add('l');
                list.Add('l');
                list.Add('o');

                string result = list.ToString();

                Assert.AreEqual(result, expectedResult);
            }
        }
    }
}
