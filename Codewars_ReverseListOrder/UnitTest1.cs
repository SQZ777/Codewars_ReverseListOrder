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
            var actual = Kata.ReverseList(new List<int> {1});
            var expected = new List<int> {1};
            Assert.AreEqual(expected,actual);
        }
    }

    public class Kata
    {
        public static List<int> ReverseList(List<int> list)
        {
            return list;
        }
    }
}
