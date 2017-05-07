using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class DetermineAgeCategoryTests
    {

        [TestMethod]
        public void Person_Stil_In_HighSchool()
        {
            Assert.AreEqual("High school", AgeDistribution.DetermineAgeCategory("18"));
        }

        [TestMethod]
        public void Finally_Retired()
        {
            Assert.AreEqual("The Golden Years", AgeDistribution.DetermineAgeCategory("78"));
        }
    }
}
