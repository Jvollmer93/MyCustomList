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
                list.Add(expectedResult);
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
                for(int i = 0; i < 5; i++)
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
                int result = list[0];
                //act
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void RemoveTestStrings()
            {
                //arrange
                CustomList<string> list = new CustomList<string>() { "Hello", "World", "!!!" };
                string expectedResult = "World";
                //assert
                list.Remove("Hello");
                list.Remove("!!!");
                int result = list[0];
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
                CustomList<int> evens = new CustomList<int>() { 2,4,6 };
                CustomList<int> expectedResult = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

                CustomList<int> result = odds.Zip(evens);

                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ZipTestChars()
            {
                CustomList<char> ace = new CustomList<char>() { 'a', 'c', 'e' };
                CustomList<char> bdf = new CustomList<char>() { 'b', 'd', 'f' };
                char[] expectedResult = new char[6] { 'a', 'b', 'c', 'd', 'e', 'f' };

                CustomList<char> result = ace.Zip(bdf);

                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ZipTestStrings()
            {

                CustomList<string> list1 = new CustomList<string>() { "This", "is", "CustomList" };
                CustomList<string> list2 = new CustomList<string>() { "class", "called" };
                CustomList<string> expectedResult = new CustomList<string>() { "This", "class", "is", "called", "CustomList" };

                string[] result = list1.Zip(list2);

                Assert.AreEqual(expectedResult, result);
            }
            [TestMethod]
            public void ToStringTestInts()
            {
                CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
                string expectedResult = "1 2 3 4 5";

                string result = ToString(list);

                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void ToStringTestChars()
            {
                CustomList<char> list = new CustomList<char>() { 'H', 'e', 'l', 'l', 'o' };
                string expectedResult = "H e l l o";

                string result = ToString(list);

                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            //public void PlusTestStrings()
            //{
            //    CustomList<string> list = new CustomList<string>();
            //    string hello = "Hello";
            //    string world = " World!";
            //    string expectedResult = "Hello World!";

            //    string result = Plus(hello, world);
            //    CustomList<string> one = new CustomList<string>();
            //    CustomList<string> two = new CustomList<string>();

            //    //overload operator
            //    CustomList<string> result = one + two;

            //    Assert.AreEqual(result, expectedResult)
            //}
            //[TestMethod]
            //public void PlusTestInts()
            //{
            //    CustomList<int> list = new CustomList<int>();
            //    int x = 5;
            //    int y = 10;
            //    int expectedResult = 15;

            //    int result = Plus(x, y);

            //    Assert.AreEqual(result, expectedResult);
            //}
            //[TestMethod]
            //public void PlusTestDoubles()
            //{
            //    CustomList<double> list = new CustomList<double>();
            //    double x = 2.5;
            //    double y = 7.2;
            //    double expectedResult = 9.7;

            //    double result = Plus(x, y);

            //    Assert.AreEqual(result, expectedResult);
            //}
            //[TestMethod]
            //public void MinusTestInts()
            //{
            //    CustomList<int> list = new CustomList<int>();
            //    int x = 10;
            //    int y = 3;
            //    int expectedResult = 7;

            //    int result = Minus(x, y);

            //    Assert.AreEqual(result, expectedResult);
            //}
            //public void MinusTestDoubles()
            //{
            //    CustomList<double> list = new CustomList<double>();
            //    double x = 13.2;
            //    double y = 6.7;
            //    double expectedResult = 6.5;

            //    double result = Minus(x, y);

            //    Assert.AreEqual(result, expectedResult);
            //}
            //public void CountTest1()
            //{
            //    CustomList<int> list = new CustomList<int>();
            //    int[] x = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            //    int expectedResult = 7;

            //    int result = Count(x);

            //    int x = list.Count;

            //    Assert.AreEqual(result, expectedResult);
            //}
            //public void CountTest2()
            //{
            //    CustomList<int> list = new CustomList<int>();
            //    list.Add(0);
            //    list.Add(1);
            //    list.Add(2);
            //    list.Add(3);
            //    list.Add(4);
            //    int expectedResult = 5;

            //    int result = Count(list);

            //    Assert.AreEqual(result, expectedResult);
            //}
            //public void CountTest3()
            //{
            //    CustomList<string> list = new CustomList<string>();
            //    list.Add("Hello");
            //    list.Add("World");
            //    list.Add("This");
            //    list.Add("Is");
            //    list.Add("John");
            //    int expectedResult = 5;

            //    int result = Count(list);

            //    Assert.AreEqual(result, expectedResult);
            //}
        }
}
