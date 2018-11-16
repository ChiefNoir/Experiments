using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mbox.Mathematics;

namespace Tests.Mathematics
{
    [TestClass]
    public class AreaTriangleCalc
    {
        [TestMethod]
        public void PositiveBulk()
        {
            {
                var result = Helper.AreaTriangleCalc(975, 8125, 8450);
                Assert.AreEqual(3802500, result);
            }

            {
                var result = Helper.AreaTriangleCalc(3, 4, 5);
                Assert.AreEqual(6, result);
            }

            {
                var result = Helper.AreaTriangleCalc(5, 5, 6);
                Assert.AreEqual(12, result);
            }
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeImposible()
        {
            var result = Helper.AreaTriangleCalc(10, 100, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNegativeNumberA()
        {
            var result = Helper.AreaTriangleCalc(-10, 10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNegativeNumberB()
        {
            var result = Helper.AreaTriangleCalc(10, -10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNegativeNumberC()
        {
            var result = Helper.AreaTriangleCalc(10, 10, -10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNaNA()
        {
            var result = Helper.AreaTriangleCalc(double.NaN, 10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNaNB()
        {
            var result = Helper.AreaTriangleCalc(10, double.NaN, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNaNC()
        {
            var result = Helper.AreaTriangleCalc(10, 10, double.NaN);
        }
    }
}
