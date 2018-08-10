using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plazius.Common;
using System.Collections.Generic;
using Plazius.Utils;
using System.Linq;
using System;

namespace Tests
{
    [TestClass]
    public class AdopterHelpersTests
    {
        [TestMethod]
        public void PositiveTests()
        {
            {
                var lst = new List<Route>
                {
                    new Route{ Start = "Мельбурн", End = "Кельн" },
                    new Route{ Start = "Москва", End = "Париж" },
                    new Route{ Start = "Кельн", End = "Москва" },
                };

                var result = AdopterHelpers.Sort(lst).ToList();

                Assert.AreEqual("Мельбурн", result[0].Start); Assert.AreEqual("Кельн", result[0].End);
                Assert.AreEqual("Кельн", result[1].Start); Assert.AreEqual("Москва", result[1].End);
                Assert.AreEqual("Москва", result[2].Start); Assert.AreEqual("Париж", result[2].End);
            }

            // -- 

            {
                var lst = new List<Route>
                {
                    new Route{ Start = "1", End = "2" },
                    new Route{ Start = "2", End = "3" },
                    new Route{ Start = "3", End = "4" },
                    new Route{ Start = "4", End = "5" },
                    new Route{ Start = "5", End = "6" },
                    new Route{ Start = "6", End = "7" },
                };

                var result = AdopterHelpers.Sort(lst).ToList();
                Assert.AreEqual("1", result[0].Start); Assert.AreEqual("2", result[0].End);
                Assert.AreEqual("2", result[1].Start); Assert.AreEqual("3", result[1].End);
                Assert.AreEqual("3", result[2].Start); Assert.AreEqual("4", result[2].End);
                Assert.AreEqual("4", result[3].Start); Assert.AreEqual("5", result[3].End);
                Assert.AreEqual("5", result[4].Start); Assert.AreEqual("6", result[4].End);
                Assert.AreEqual("6", result[5].Start); Assert.AreEqual("7", result[5].End);
            }

            // -- 

            {
                var lst = new List<Route>
                {
                    new Route{ Start = "6", End = "7" },
                    new Route{ Start = "1", End = "2" },
                    new Route{ Start = "5", End = "6" },
                    new Route{ Start = "3", End = "4" },
                    new Route{ Start = "4", End = "5" },
                    new Route{ Start = "2", End = "3" },
                };

                var result = AdopterHelpers.Sort(lst).ToList();
                Assert.AreEqual("1", result[0].Start); Assert.AreEqual("2", result[0].End);
                Assert.AreEqual("2", result[1].Start); Assert.AreEqual("3", result[1].End);
                Assert.AreEqual("3", result[2].Start); Assert.AreEqual("4", result[2].End);
                Assert.AreEqual("4", result[3].Start); Assert.AreEqual("5", result[3].End);
                Assert.AreEqual("5", result[4].Start); Assert.AreEqual("6", result[4].End);
                Assert.AreEqual("6", result[5].Start); Assert.AreEqual("7", result[5].End);
            }

            //--

            {
                var lst = new List<Route>
                {
                    new Route{ Start = "Мельбурн", End = "Кельн" },
                    new Route{ Start = "Кельн", End = "Москва" },
                    new Route{ Start = "Москва", End = "Кельн" },
                };

                var result = AdopterHelpers.Sort(lst).ToList();
                Assert.AreEqual("Мельбурн", result[0].Start); Assert.AreEqual("Кельн", result[0].End);
                Assert.AreEqual("Кельн", result[1].Start); Assert.AreEqual("Москва", result[1].End);
                Assert.AreEqual("Москва", result[2].Start); Assert.AreEqual("Кельн", result[2].End);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NegativeTestNull()
        {
            AdopterHelpers.Sort(null);
        }
    }
}
