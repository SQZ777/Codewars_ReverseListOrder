using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_ReverseListOrder
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_1_Should_Be_1()
        {
           GetResult(new List<int> { 1 }, Kata.ReverseList(new List<int> { 1 }));
        }

        [TestMethod]
        public void Input_1_2_Should_Be_2_1()
        {
            GetResult(new List<int> { 2, 1 }, Kata.ReverseList(new List<int> { 1, 2 }));
        }

        [TestMethod]
        public void Input_1_2_3_Should_Be_3_2_1()
        {
            GetResult(new List<int> { 3, 2, 1 }, Kata.ReverseList(new List<int> { 1, 2, 3 }));
        }

        private static void GetResult(List<int> expected, List<int> actual)
        {
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public static List<int> ReverseList(List<int> list)
        {
            //var listArray = list.ToArray();
            //Array.Reverse(listArray);
            //return new List<int>(listArray);
            return Enumerable.Reverse(list).ToList();
        }
    }
}
