﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
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

        [TestMethod] // testar om isCorrectTriangle returnerar true för en giltig triangel
        public void isCorrectTriangleTest()
        {
            Triangle tria = new Triangle(2.2, 3.2, 2.2);
            Assert.IsTrue(tria.isCorrectTriangle());
        }

        [TestMethod] // testar om Triangle kastar ett undantag för en triangel med sidan 0
        [ExpectedException(typeof(ArgumentException))]

        public void isZeroSideCorrectTriangleTest()
        {
            Triangle tria = new Triangle(2.2, 0.0, 2.2);
        }

        [TestMethod] // testar om Triangle kastar ett undantag för en triangel med negativ sida
        [ExpectedException(typeof(ArgumentException))]

        public void isNegativeSideCorrectTriangleTest()
        {
            Triangle tria = new Triangle(-1.3, 3.2, 2.2);
        }

        [TestMethod] // testar om Triangle kastar ett undantag för en triangel som är en rak linje
        [ExpectedException(typeof(ArgumentException))]

        public void isStraightLineCorrectTriangleTest()
        {
            Triangle tria = new Triangle(3.0, 2.0, 1.0);
        }

        [TestMethod] // testar om Triangle kastar ett undantag för en triangel där en sida är längre än de andra två tillsammans
        [ExpectedException(typeof(ArgumentException))]

        public void isOneSideTooLongCorrectTriangleTest()
        {
            Triangle tria = new Triangle(9.0, 2.0, 1.0);
        }

        [TestMethod] // testar array konstruktorn
        public void arrayConstructorTest()
        {
            double[] arraySides;
            arraySides = new double[] { 1.3, 3.5, 2.3 };
            Triangle tria = new Triangle(arraySides);
            Assert.IsTrue(tria.isCorrectTriangle());
        }

        [TestMethod] // testar array konstruktorn med felaktig triangel
        [ExpectedException(typeof(ArgumentException))]

        public void badTriangleArrayConstructorTest()
        {
            double[] arraySides;
            arraySides = new double[] { 99, 3.5, 2.3 };
            Triangle tria = new Triangle(arraySides);
        }

        [TestMethod] // testar point konstruktorn
        public void pointConstructorTest()
        {
            Point pointa = new Point(1, 0);
            Point pointb = new Point(2, 3);
            Point pointc = new Point(3, 5);
            Triangle tria = new Triangle(pointa, pointb, pointc);
            Assert.IsTrue(tria.isCorrectTriangle());
        }

        [TestMethod] // testar point konstruktorn med felaktig triangel
        [ExpectedException(typeof(ArgumentException))]

        public void badTrianglePointConstructorTest()
        {
            Point pointa = new Point(1, 0);
            Point pointb = new Point(1, 0);
            Point pointc = new Point(3, 5);
            Triangle tria = new Triangle(pointa, pointb, pointc);

        }

        [TestMethod] // testar array-point konstruktorn
        public void arrayPointConstructorTest()
        {
            Point pointa = new Point(1, 0);
            Point pointb = new Point(2, 3);
            Point pointc = new Point(3, 5);
            Point[] pointArray;
            pointArray = new Point[] {pointa, pointb, pointc};
            Triangle tria = new Triangle(pointArray);
            Assert.IsTrue(tria.isCorrectTriangle());   
        }

        [TestMethod] // testar array-point konstruktorn med felaktig triangel
        [ExpectedException(typeof(ArgumentException))]

        public void badTriangleArrayPointConstructorTest()
        {
            Point pointa = new Point(2, 3);
            Point pointb = new Point(2, 3);
            Point pointc = new Point(2, 3);
            Point[] pointArray;
            pointArray = new Point[] { pointa, pointb, pointc };
            Triangle tria = new Triangle(pointArray);
        }
    }
}
