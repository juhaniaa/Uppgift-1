using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class UnitTestTri
    {
        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tria = new Triangle(2.2, 3.2, 2.2);
            Assert.IsTrue(tria.isIsosceles());
        }

        [TestMethod]
        public void isNotIsoscelesTest()
        {
            Triangle tria = new Triangle(2.2, 3.2, 2.4);
            Assert.IsFalse(tria.isIsosceles());
        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle tria = new Triangle(2.1, 3.2, 4.2);
            Assert.IsTrue(tria.isEquilateral());
        }

        [TestMethod]
        public void isNotEquilateralTest()
        {
            Triangle tria = new Triangle(2.1, 3.2, 3.2);
            Assert.IsFalse(tria.isEquilateral());
        }

        [TestMethod]
        public void isScaleneTest()
        {
            Triangle tria = new Triangle(3.4, 3.4, 3.4);
            Assert.IsTrue(tria.isScalene());
        }

        [TestMethod]
        public void isNotScaleneTest()
        {
            Triangle tria = new Triangle(3.4, 3.4, 3.5);
            Assert.IsFalse(tria.isScalene());
        }

        [TestMethod]
        public void arrayConstructorTest()
        {
            double[] arraySides;
            arraySides = new double[] { 1.3, 3.5, 2.3 };
            Triangle tria = new Triangle(arraySides);
            //double[] correctArraySides;
            //correctArraySides = tria.checkSides();

        }

        [TestMethod]
        public void IsAnton()
        {
            //should be == true
            Triangle anton = new Triangle(1, 2, 2);
            Assert.IsTrue(anton.isAnton());
        }

        [TestMethod]
        public void pointConstructorsTest()
        {
            Point pointa = new Point(1, 0);
            Point pointb = new Point(2, 3);
            Point pointc = new Point(3, 5);
            Triangle tria = new Triangle(pointa, pointb, pointc);
            Assert.IsTrue(tria.isEquilateral());
        }

        [TestMethod]
        public void checkSidesTest()
        {
            Triangle tria = new Triangle(2.4, 3.1, 2.1);
            tria.checkSides();
        }
    }
}
