using System;
using CodeEval_Moderate_Problems_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class FindAbsurdElementTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("0",ArrayAbsurdity.FindAbsurdNumberInArray("5;0,1,2,3,0"));
        }
    }
}
