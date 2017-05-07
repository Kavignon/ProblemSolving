using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class ChangeLetterCaseTests
    {
        [TestMethod]
        public void First_Test_Should_Pass()
        {
            Assert.AreEqual("hELLO WORLD!", SwapCase.ChangeLetterCase("Hello world!"));
        }

        [TestMethod]
        public void Failure_When_Expecting_Result_String_Without_Swap()
        {
            Assert.AreNotEqual("Hello World!", SwapCase.ChangeLetterCase("Hello world!"));
        }
    }
}
