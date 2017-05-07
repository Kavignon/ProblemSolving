using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class SimpleDoubleSortingTests
    {
        [TestMethod]
        public void Sort_Doubles_As_String()
        {
            Assert.AreEqual("-38.797 7.581 14.354 70.920 90.374 99.323",Sorting.SimpleDoubleSorting("70.920 -38.797 14.354 99.323 90.374 7.581"));
        }
    }
}
