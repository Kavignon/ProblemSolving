using System;
using CodeEval_Easy_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class MultiplyElementsInListTests
    {
        [TestMethod]
        public void Mulplication_Of_String_as_Numbers()
        {
            Assert.AreEqual("135 0 54", MultiplyList.Multiply_Elements_Within_List("9 0 6 | 15 14 9"));
        }
    }
}
