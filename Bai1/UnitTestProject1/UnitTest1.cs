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
    }
}
