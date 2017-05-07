using System;
using CodeEval_Moderate_Problems_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class DetermineLongestLinesInFileTests
    {
        [TestMethod]
        public void There_Should_Be_2_Lines_Printed()
        {
            Assert.AreEqual("San Francisco\nHello World\n",
                DocumentReader.DetermineLongestLinesInFile("2,Hello World,CodeEval,Quick Fox,A,San Francisco"));
        }
    }
}
