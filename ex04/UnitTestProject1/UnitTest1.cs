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
        [TestMethod]
        public void testSquare()
        {
            int kq1 = Program.Square(-2);
            Assert.AreEqual(4, kq1);
            int kq2 = Program.Square(4);
            Assert.AreEqual(16, kq2);
        }
        [TestMethod]
        public void testPow()
        {
            int kq1 = Program.pow(2, 3);
            Assert.AreEqual(8, kq1);
            int kq2 = Program.pow(2, 0);
            Assert.AreEqual(1, kq2);

        }
        [TestMethod]
        public void testABS()
        {
            int kq1 = Program.abs(-4);
            Assert.AreEqual(4, kq1);
            int kq2 = Program.abs(8);
            Assert.AreEqual(8, kq2);
            int kq3 = Program.abs(0);
            Assert.AreEqual(1, kq3);
        }
        [TestMethod]
        public void testCeil()
        {
            int kq1 = Program.mathceil(4.2);
            Assert.AreEqual(5, kq1);
            int kq2 = Program.mathceil(0);
            Assert.AreEqual(0, kq2);
            int kq3 = Program.mathceil(5);
            Assert.AreEqual(5, kq3);
        }
        [TestMethod]
        public void testFloor()
        {
            int kq1 = Program.mathFloor(4.4);
            Assert.AreEqual(4, kq1);
        }
    }
}
