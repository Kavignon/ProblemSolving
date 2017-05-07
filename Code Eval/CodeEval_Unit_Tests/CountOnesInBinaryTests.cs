using System;
using CodeEval_Moderate_Problems_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class CountOnesInBinaryTests
    {
        [TestMethod]
        public void There_Are_No_Ones()
        {
            Assert.AreEqual(0, BinaryRepresentation.NumberOfOnesInBinary("0000000000000000"));
        }

        [TestMethod]
        public void String_Is_Emppty()
        {
            Assert.AreEqual(0, BinaryRepresentation.NumberOfOnesInBinary(""));
        }

        [TestMethod]
        public void There_Are_Ones()
        {
            Assert.AreEqual(9, BinaryRepresentation.NumberOfOnesInBinary("0101110101010101"));
        }
    }
}
