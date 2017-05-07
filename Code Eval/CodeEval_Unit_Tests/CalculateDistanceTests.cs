using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class CalculateDistanceTests
    {
        [TestMethod]
        public void Computed_Distance_Should_Be_26()
        {
            Assert.AreEqual(26, CalculateDistance.ComputeDistance("(25, 4) (1, -6)"));
        }

        [TestMethod]
        public void Computed_Distance_Should_Be_90()
        {
            Assert.AreEqual(90, CalculateDistance.ComputeDistance("(47, 43) (-25, -11)"));

        }
    }
}
