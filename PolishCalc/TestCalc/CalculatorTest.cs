using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolishCalc;
using System;

namespace TestCalc
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalcValid()
        {
            Assert.AreEqual(15, Calculator.Calc(@"+ 10 5"));
            Assert.AreEqual(5, Calculator.Calc(@"- 10 5"));
            Assert.AreEqual(2, Calculator.Calc(@"/ 10 5"));
            Assert.AreEqual(50, Calculator.Calc(@"* 10 5"));


            Assert.AreEqual(15.2d, Calculator.Calc(@"+ 10,1 5,1"));
            Assert.AreEqual(-7, Calculator.Calc(@"* - 5 6 7"));
            Assert.AreEqual(5, Calculator.Calc(@"- * / 15 - 7 + 1 1 3 + 2 + 1 1"));


            Assert.AreEqual(50, Calculator.Calc(@"* 10              5"));
            Assert.AreEqual(-7, Calculator.Calc(@"*(- 5 6) 7"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcInvalid_Null()
        {
            Calculator.Calc(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcInvalid_Empty()
        {
            Calculator.Calc("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcInvalid_Word()
        {
            Calculator.Calc("you_will_see");            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcInvalid_WordsAndNumbers()
        {
            Calculator.Calc("/ 10 5 seven");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CalcInvalid_MissingParameters()
        {
            Calculator.Calc("/ 10");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CalcInvalid_MissingParameters2()
        {
            Calculator.Calc("+ + + + + + 12");
        }
    }
}
