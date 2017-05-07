using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class FindLowestUniqueNumberPosition
    {
        [TestMethod]
        public void Lowest_Unique_Number_Index_Has_Been_Found()
        {
            Assert.AreEqual(5, LowestNumber.LowestUniqueIndex("3 3 9 1 6 5 8 1 5 3"));
        }

        [TestMethod]
        public void Lowest_Unique_Number_Index_Was_Not_Found()
        {
            Assert.AreEqual(0, LowestNumber.LowestUniqueIndex("9 2 9 9 1 8 8 8 2 1 1"));
        }
    }
}
