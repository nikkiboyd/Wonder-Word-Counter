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
            string userSentence = "the cat";
            char[] splitLetters = new char[] { 't', 'h', 'e', ' ', 'c', 'a', 't' }; 
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            char[] result = newCounter.SplitSentence(userSentence);
            CollectionAssert.AreEqual(splitLetters, result);
        }
    }
}
