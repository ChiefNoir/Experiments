using Microsoft.VisualStudio.TestTools.UnitTesting;
using LuxoftWithoutChange.Utils;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Tests
{
    [TestClass]
    public class SumFinderTests
    {
        [TestMethod]
        public void TestValid()
        {
            var resultEmptyInput = SumFinder.FindSumSequences(100, new List<int>());
            Assert.AreEqual(0, resultEmptyInput.Count);

            var resultNone = SumFinder.FindSumSequences(100, new List<int> { 1, 2, 3, 4, 5 });
            Assert.AreEqual(0, resultNone.Count);

            var resultTwo = SumFinder.FindSumSequences(12, new List<int> { 1, 9, 7, 3, 5 });
            Assert.AreEqual(true, resultTwo.SequenceEqual(new List<int> { 9, 3 }));
            
            var resultOne = SumFinder.FindSumSequences(100, new List<int> { 100 });
            Assert.AreEqual(true, resultOne.SequenceEqual(new List<int> { 100}));

            var resultThree = SumFinder.FindSumSequences(10, new List<int> { 1, 2, 3, 4, 5 });
            Assert.AreEqual(true, resultThree.SequenceEqual(new List<int> { 1, 2, 3, 4 }));


            var resultLong = SumFinder.FindSumSequences(100, new List<int> { 100, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1});
            Assert.AreEqual(true, resultLong.SequenceEqual(new List<int> { 100}));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInValid()
        {
            SumFinder.FindSumSequences(100, null);
        }
    }
}
