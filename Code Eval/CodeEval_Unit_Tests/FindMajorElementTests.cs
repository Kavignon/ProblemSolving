using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class FindMajorElementTests
    {
        [TestMethod]
        public void Major_Element_Should_Be_19()
        {
            Assert.IsTrue(
                TheMajorElement.FindTheMajorElement(
                    "92,19,19,76,19,21,19,85,19,19,19,94,19,19,22,67,83,19,19,54,59,1,19,19") == "19");
        }

        [TestMethod]
        public void Major_Element_Should_Be_None()
        {
            Assert.IsTrue(
                TheMajorElement.FindTheMajorElement(
                    "0,0,0,0,1,1,1,1,2,2,2,2") == "None");
        }

    }
}
