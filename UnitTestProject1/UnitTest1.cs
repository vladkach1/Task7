using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task7;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.q(1,2,3,4));
        }
        [TestMethod]
        public void TestMethod2()
        {

            Assert.IsTrue(Program.q(1, 2, 3, 4));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(Program.q(4, 2, 1, 5));
        }
    }
}
