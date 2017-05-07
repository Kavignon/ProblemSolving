using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class DeterminePossibleKnightPositionTests
    {
        [TestMethod]
        public void Current_Position_Should_Allow_Four_Positions()
        {
            Assert.AreEqual("e1 e3 f4 h4", KnightMoves.DeterminePossibleKnightPositions("g2"));
        }

        [TestMethod]
        public void Current_Position_Should_Allow_Eight_Positions()
        {
            Assert.AreEqual("b5 b7 c4 c8 e4 e8 f5 f7", KnightMoves.DeterminePossibleKnightPositions("d6"));
        }
    }
}