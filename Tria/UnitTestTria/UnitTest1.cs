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
    }
}
