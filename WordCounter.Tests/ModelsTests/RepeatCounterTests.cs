using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter;

namespace WordCounterTests
{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void RepeatCounter_WordAndSentenceMatch_WordsMatch()
        {
            string testWord = "cat";
            string testSentence = "cat";
            RepeatCounter newCounter = new RepeatCounter("cat", "cat");
            Assert.AreEqual(testWord, testSentence);
        }

        [TestMethod]
        public void SplitSentence_SplitWordsToList_IndividualWords()
        {
            string userSentence = "The cat is happy";
            List<string> splitSentence = new List<string> { "The", "cat", "is", "happy" }; 
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            List<string> result = newCounter.SplitSentence(userSentence);
            CollectionAssert.AreEqual(splitSentence, result);
        }
    }
}
