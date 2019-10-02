using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex4b;
namespace UnitTestProjectEx4b1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Contain5()
        {
            int[] arr = new int[] { 1,2,3,4,5};
            bool cont5 = Program.Contain5(arr);
            Assert.AreEqual(true, cont5);

            int[] arr1 = new int[] { 1, 2, 3, 4, 6 };
            bool NotCont5 = Program.Contain5(arr1);
            Assert.AreEqual(false, NotCont5);
        }
        [TestMethod]
        public void Contain5or6()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            bool cont5or6 = Program.Contain5Or6(arr);
            Assert.AreEqual(true, cont5or6);

            int[] arr1 = new int[] { 1, 2, 3, 4, 6 };
            bool cont5or61 = Program.Contain5Or6(arr1);
            Assert.AreEqual(true, cont5or6);

            int[] arr2 = new int[] { 1, 2, 3, 4};
            bool NotCont5or6 = Program.Contain5Or6(arr2);
            Assert.AreEqual(false, NotCont5or6);
        }
        [TestMethod]
        public void Contain5And6()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 , 6};
            bool cont5And6 = Program.Contain5And6(arr);
            Assert.AreEqual(true, cont5And6);

            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool cont5A6 = Program.Contain5And6(arr1);
            Assert.AreEqual(false, cont5A6);

            int[] arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool cont5d6 = Program.Contain5And6(arr2);
            Assert.AreEqual(false, cont5d6);
        }
        [TestMethod]
        public void Count5()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int count5 = Program.Count5(arr);
            Assert.AreEqual(1, count5);

            int[] arr1 = new int[] { 1, 2, 3, 4, 6};
            int count51 = Program.Count5(arr1);
            Assert.AreEqual(0, count51);
        }
        [TestMethod]
        public void Contain5Or6()
        {
        }
        [TestMethod]
        public void Sum()
        {
        }
    }
}
