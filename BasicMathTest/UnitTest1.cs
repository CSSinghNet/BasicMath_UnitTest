using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathTest
{
 
    [TestClass]
    public class UnitTest1
    {
        BasicMaths bm = new BasicMaths();
        [TestMethod]
        public void Test_AddMethod()
        {  //Arrange
             bm = new BasicMaths();
            //Act
            double res = bm.Add(10, 10);
            //Assert
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
             bm = new BasicMaths();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
             bm = new BasicMaths();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
             bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
