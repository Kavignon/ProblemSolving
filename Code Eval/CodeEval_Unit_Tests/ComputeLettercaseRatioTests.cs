using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class ComputeLettercaseRatioTests
    {
        [TestMethod]
        public void Ratio_is_50_50()
        {
            Assert.AreEqual("lowercase: 50.00 uppercase: 50.00",
                LettercasePercentage.ComputeLettercaseRatio("thisTHIS"));
        }

        [TestMethod]
        public void Ration_Is_0_100()
        {
            Assert.AreEqual("lowercase: 0.00 uppercase: 100.00",
                LettercasePercentage.ComputeLettercaseRatio("N"));
        }
    }
}
