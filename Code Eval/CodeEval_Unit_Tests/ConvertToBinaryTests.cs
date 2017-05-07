using System;
using CodeEval_Moderate_Problems_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class ConvertToBinaryTests
    {
        [TestMethod]
        public void Conversion_Should_Pass()
        {
            Assert.AreEqual("1101",DecimalConverter.ConvertToBinary(13));
        }
    }
}
