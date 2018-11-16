using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mbox.Mathematics;

namespace Tests.Mathematics
{
    [TestClass]
    public class AreaCirlceCalc
    {
        [TestMethod]
        public void PositiveBulk()
        {
            {
                var result = Helper.AreaCirlceCalc(0);
                Assert.AreEqual(0, result);
            }

            {
                var result = Helper.AreaCirlceCalc(1);
                Assert.AreEqual(Math.PI, result);
            }

            {
                var result = Helper.AreaCirlceCalc(2);
                Assert.AreEqual(Math.PI * 4, result);
            }

            {
                var result = Helper.AreaCirlceCalc(10);
                Assert.AreEqual(Math.PI * 100, result);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeLessThanZero()
        {
            var result = Helper.AreaCirlceCalc(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNan()
        {
            var result = Helper.AreaCirlceCalc(double.NaN);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativePositiveInfinity()
        {
            var result = Helper.AreaCirlceCalc(double.PositiveInfinity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeNegativeInfinity()
        {
            var result = Helper.AreaCirlceCalc(double.NegativeInfinity);
        }
        
    }
}
