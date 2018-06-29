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
        public void SplitWord_SplitMainWordToCharArray_WordLetters()
        {
            string userWord = "cat";
            string userSentence = "the cat";
            char[] splitWordLetters = new char[] { 'c', 'a', 't' };
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            char[] result = newCounter.SplitWordToCheck(userWord);
            CollectionAssert.AreEqual(splitWordLetters, result);
        }

        [TestMethod]
        public void SplitSentence_SplitWordsToCharArray_SentenceLetters()
        {
            string userSentence = "the cat";
            char[] splitSentenceLetters = new char[] { 't', 'h', 'e', ' ', 'c', 'a', 't' };
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            char[] result = newCounter.SplitSentence(userSentence);
            CollectionAssert.AreEqual(splitSentenceLetters, result);
        }
        [TestMethod]
        public void CountOccurences_FindMatchesAndCount_Frequency()
        {
            string userWord = "cat";
            string userSentence = "the cat is a cat";
            int expectedFrequency = 2;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurences(userWord, userSentence);
            Assert.AreEqual(expectedFrequency, result);
        }
    }
}
