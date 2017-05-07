using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void First_Odd_Number_Should_Be_One()
        {
            Assert.AreEqual(1,OddNumbers.ComputeOddNumberList()[0]);
        }

        [TestMethod]
        public void Last_Odd_Number_Should_Be_Ninety_Nine()
        {
            var lastElement = OddNumbers.ComputeOddNumberList().Count - 1;
            Assert.AreEqual(99, OddNumbers.ComputeOddNumberList()[lastElement]);
        }

        [TestMethod]
        public void No_Number_Should_Be_Even_Number()
        {
            var rnd = new Random();
            var randomValue = rnd.Next(0, OddNumbers.ComputeOddNumberList().Count);
            Assert.IsTrue(OddNumbers.ComputeOddNumberList()[randomValue]%2 != 0);
        }
    }
}
