using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriUnitTest
{
    [TestClass]
    public class UnitTestTri
    {
        [TestMethod] // testar om likbenhets metoden returenerar true för likbent triangel
        public void isIsoscelesTest()
        {
            Triangle tria = new Triangle(2.2, 3.2, 2.2);
            Assert.IsTrue(tria.isIsosceles());
        }

        [TestMethod] // testar om likbenhets metoden returenerar false för en icke likbent triangel
        public void isNotIsoscelesTest()
        {
            Triangle tria = new Triangle(2.2, 3.2, 2.4);
            Assert.IsFalse(tria.isIsosceles());
        }

        [TestMethod] // testar om olika sidor metoden returenerar true för triangel med olika sidor
        public void isEquilateralTest()
        {
            Triangle tria = new Triangle(2.1, 3.2, 4.2);
            Assert.IsTrue(tria.isEquilateral());
        }

        [TestMethod] // testar om olika sidor metoden returenerar false för triangel med lika sidor
        public void isNotEquilateralTest()
        {
            Triangle tria = new Triangle(2.1, 3.2, 3.2);
            Assert.IsFalse(tria.isEquilateral());
        }

        [TestMethod] // testar om liksidighets metoden returenerar true för liksidig triangel
        public void isScaleneTest()
        {
            Triangle tria = new Triangle(3.4, 3.4, 3.4);
            Assert.IsTrue(tria.isScalene());
        }

        [TestMethod] // testar om liksidighets metoden returenerar false för icke liksidig triangel
        public void isNotScaleneTest()
        {
            Triangle tria = new Triangle(3.4, 3.4, 3.5);
            Assert.IsFalse(tria.isScalene());
        }

        [TestMethod] // testar array konstruktorn
        public void arrayConstructorTest()
        {
            double[] arraySides;
            arraySides = new double[] { 1.3, 3.5, 2.3 };
            Triangle tria = new Triangle(arraySides);
            //double[] correctArraySides;
            //correctArraySides = tria.checkSides();

        }

        [TestMethod] // testar point konstruktorn
        public void pointConstructorTest()
        {
            Point pointa = new Point(1, 0);
            Point pointb = new Point(2, 3);
            Point pointc = new Point(3, 5);
            Triangle tria = new Triangle(pointa, pointb, pointc);
            Assert.IsTrue(tria.isEquilateral());
        }

        [TestMethod] // testar array point konstruktorn
        public void arrayPointConstructorTest()
        {
            Point pointa = new Point(1, 0);
            Point pointb = new Point(2, 3);
            Point pointc = new Point(3, 5);
            Point[] pointArray;
            pointArray = new Point[] { pointa, pointb, pointc };
            Triangle tria = new Triangle(pointArray);
            
        }
    }
}
