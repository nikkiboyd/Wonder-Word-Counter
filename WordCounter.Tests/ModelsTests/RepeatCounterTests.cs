using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter;

namespace WordCounter.Test
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void GetWordToCheck_ReturnsWordFromUserToRepeatCounter_UserInputString()
        {
            string wordToCheck = "cat";
            List<string> sentenceToCheck = new List<string> { "false" };
            RepeatCounter newRepeatCounter = new RepeatCounter(wordToCheck, sentenceToCheck);
            string result = newRepeatCounter.GetWordToCheck();
            Assert.AreEqual(wordToCheck, result);
        }
    }
}
