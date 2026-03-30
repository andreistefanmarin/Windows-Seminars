using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var q = new UnitTest1();

            int result = q.Add(5,2);

            Assert.AreEqual(7, result);
        }
    }
}
