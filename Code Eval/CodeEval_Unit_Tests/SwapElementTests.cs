using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class SwapElementTests
    {
        [TestMethod]
        public void Swap_First_And_Last()
        {
            Assert.AreEqual("9 2 3 4 5 6 7 8 1", SwapCase.SwapElementIndex("1 2 3 4 5 6 7 8 9 : 0-8"));
        }

        [TestMethod]
        public void Swap_Many()
        {
            Assert.AreEqual("2 4 3 1 5 6 7 8 9 10", SwapCase.SwapElementIndex("1 2 3 4 5 6 7 8 9 10 : 0-1, 1-3"));
        }

    }
}
