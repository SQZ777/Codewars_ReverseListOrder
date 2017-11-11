using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_ReverseListOrder
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_1_Should_Be_1()
        {
            var actual = Kata.ReverseList(new List<int> { 1 });
            var expected = new List<int> { 1 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_1_2_Should_Be_2_1()
        {
            var actaul = Kata.ReverseList(new List<int> { 1, 2 });
            var expected = new List<int> { 2, 1 };
            CollectionAssert.AreEqual(expected, actaul);
        }

        [TestMethod]
        public void Input_1_2_3_Should_Be_3_2_1()
        {
            var actual = Kata.ReverseList(new List<int>{1,2,3});
            var expected = new List<int>{3,2,1};
            CollectionAssert.AreEqual(expected,actual);
        }

    }

    public class Kata
    {
        public static List<int> ReverseList(List<int> list)
        {
            var listArray = list.ToArray();
            Array.Reverse(listArray);
            return new List<int>(listArray);
        }
    }
}
