using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex4b;

namespace test4b
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ar1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.problem1(ar1);
            Assert.AreEqual(true, result1);

            int[] ar2 = new int[] { 1, 3, 6, 4, 7 };
            bool result2 = Program.problem1(ar2);
            Assert.AreEqual(false, result2);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] ar1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.problem2(ar1);
            Assert.AreEqual(true, result1);

            int[] ar2 = new int[] { 1, 3, 6, 4, 7 };
            bool result2 = Program.problem2(ar2);
            Assert.AreEqual(true, result2);

            int[] ar3 = new int[] { 1, 3, 4, 7 };
            bool result3 = Program.problem2(ar3);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] ar1 = new int[] { 1, 2, 3, 4, 5, 6 };
            bool result1 = Program.problem3(ar1);
            Assert.AreEqual(true, result1);

            int[] ar2 = new int[] { 1, 3, 6, 4, 7 };
            bool result2 = Program.problem3(ar2);
            Assert.AreEqual(false, result2);

            int[] ar3 = new int[] { 1, 3, 4, 7 };
            bool result3 = Program.problem3(ar3);
            Assert.AreEqual(false, result3);

            int[] ar4 = new int[] { 1, 3, 5, 4, 7 };
            bool result4 = Program.problem3(ar4);
            Assert.AreEqual(false, result4);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] ar1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program.count1(ar1);
            Assert.AreEqual(1, result1);

            int[] ar2 = new int[] { 5, 2, 3, 5, 5, 6 };
            int result2 = Program.count1(ar2);
            Assert.AreEqual(3, result2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] ar1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program.count2(ar1);
            Assert.AreEqual(2, result1);

            int[] ar2 = new int[] { 5, 2, 3, 5, 5, 6 };
            int result2 = Program.count2(ar2);
            Assert.AreEqual(4, result2);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] ar1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program.sum(ar1);
            Assert.AreEqual(21, result1);
        }
    }
}
