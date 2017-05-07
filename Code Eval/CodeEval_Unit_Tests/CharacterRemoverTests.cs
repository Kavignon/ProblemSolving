using System;
using CodeEval_Moderate_Problems_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeEval_Unit_Tests
{
    [TestClass]
    public class CharacterRemoverTests
    {
        [TestMethod]
        public void Character_Removal_Cannot_Be_Applied()
        {
            Assert.AreEqual(null, CharacterRemover.RemoveInputCharactersFromString("", ""));
        }

        [TestMethod]
        public void Character_Removal_Cannot_Be_Applied_With_Second_Overload()
        {
            Assert.AreEqual(null, CharacterRemover.RemoveInputCharactersFromString(""));
        }

        [TestMethod]
        public void Remove_Single_Character_From_Input_String()
        {
            Assert.AreEqual("how re you", CharacterRemover.RemoveInputCharactersFromString("how are you", "a"));
        }

        [TestMethod]
        public void Remove_Single_Character_From_Input_String_With_The_Second_Overload()
        {
            Assert.AreEqual("how re you", CharacterRemover.RemoveInputCharactersFromString("how are you, a"));
        }

        [TestMethod]
        public void Remove_Multiple_Characters_Without_Respecting_Alphabetic_Order_From_Input_String()
        {
            Assert.AreEqual("h wr", CharacterRemover.RemoveInputCharactersFromString("hello world", "oeld"));
        }

        [TestMethod]
        public void Remove_Multiple_Characters_Without_Respecting_Alphabetic_Order_From_Input_String_With_Second_Overload()
        {
            Assert.AreEqual("h wr", CharacterRemover.RemoveInputCharactersFromString("hello world, oeld"));
        }

        [TestMethod]
        public void Remove_Single_Special_Character_From_Input_String()
        {
            Assert.AreEqual("hello? world???##$@@@#@#", CharacterRemover.RemoveInputCharactersFromString("hello?! world!!!???##$@@@#@#", "!"));
        }

        [TestMethod]
        public void Remove_Single_Special_Character_From_Input_String_With_Second_Overload()
        {
            Assert.AreEqual("hello? world???##$@@@#@#", CharacterRemover.RemoveInputCharactersFromString("hello?! world!!!???##$@@@#@#, !"));
        }

        [TestMethod]
        public void Remove_Multiple_Special_Characters_From_Input_String()
        {
            Assert.AreEqual("hello world##$##", CharacterRemover.RemoveInputCharactersFromString("hello?! world!!!???##$@@@#@#", "!@?"));
        }

        [TestMethod]
        public void Remove_Multiple_Special_Characters_From_Input_String_With_Second_Overload()
        {
            Assert.AreEqual("hello world##$##", CharacterRemover.RemoveInputCharactersFromString("hello?! world!!!???##$@@@#@#, !@?"));
        }
    }
}
