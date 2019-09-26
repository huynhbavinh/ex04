using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex04;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }
        [TestMethod]
        public void TestIsPrime()
        {
            bool kq1 = Program.IsPrime(0);
            Assert.AreEqual(false, kq1);
            bool kq2 = Program.IsPrime(1);
            Assert.AreEqual(false, kq2);
            bool kq3 = Program.IsPrime(2);
            Assert.AreEqual(true, kq3);
            bool kq4 = Program.IsPrime(3);
            Assert.AreEqual(true, kq4);
            bool kq5 = Program.IsPrime(4);
            Assert.AreEqual(false, kq1);
            bool kq6 = Program.IsPrime(-1);
            Assert.AreEqual(false, kq1);
        }
    }
}
