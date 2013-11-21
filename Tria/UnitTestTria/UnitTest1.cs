using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tria = new Triangle(2.2, 3.2, 2.2);
            Assert.IsTrue(tria.isIsosceles());
        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle tria = new Triangle(2.1, 3.2, 4.2);
            Assert.IsTrue(tria.isEquilateral());
        }
        
        [TestMethod]
        public void isScaleneTest()
        {
            Triangle tria = new Triangle(3.4, 3.4, 3.4);
            Assert.IsTrue(tria.isScalene());
        }
    }
}
