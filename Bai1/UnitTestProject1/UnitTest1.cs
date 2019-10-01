using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
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

            bool result12 = Program.IsOdd(12);
            Assert.AreEqual(false, result12);
        
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result28 = Program.IsEven(28);
            Assert.AreEqual(true, result28);

            bool result9 = Program.IsEven(9);
            Assert.AreEqual(false, result9);
        }
        [TestMethod]
        public void IsPrime()
        {
            bool resultnegative = Program.Prime(-8);
            Assert.AreEqual(false, resultnegative);

            bool result0 = Program.Prime(0);
            Assert.AreEqual(false, result0);

            bool result1 = Program.Prime(1);
            Assert.AreEqual(false, result1);

            bool result2 = Program.Prime(2);
            Assert.AreEqual(true, result2);

            bool result3 = Program.Prime(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.Prime(4);
            Assert.AreEqual(false, result4);

           


        }
        [TestMethod]
        public void Abs()
        {
            int abs1 = Program.Abs(-8);
            Assert.AreEqual(-8, abs1);

            int abs2 = Program.Abs(0);
            Assert.AreEqual(0, abs2);

            int abs3 = Program.Abs(8);
            Assert.AreEqual(8, abs3);
        }

        [TestMethod]
        public void Ceil()
        {
            int ceil1 = Program.Ceil(2.5);
            Assert.AreEqual(3, ceil1);

            int ceil2 = Program.Ceil(-5.1);
            Assert.AreEqual(-5, ceil2);

            int ceil3 = Program.Ceil(-4.9);
            Assert.AreEqual(-4, ceil3);

        }
        [TestMethod]
        public void Floor()
        {
            int floor1 = Program.Floor(-5.1);
            Assert.AreEqual(-6 , floor1);

            int floor2 = Program.Floor(6.2);
            Assert.AreEqual(6 , floor2);

        }
        [TestMethod]
        public void Pow()
        {
            double pow1 = Program.Pow(2, 3);
            Assert.AreEqual(8, pow1);

            double pow2 = Program.Pow(2, -3);
            Assert.AreEqual(0.125, pow2);
        }
         [TestMethod]
        public void Sin()
        {
            double sinx1 = Program.Sin(0);
            Assert.AreEqual(0, sinx1);

            
        }
    }
}
