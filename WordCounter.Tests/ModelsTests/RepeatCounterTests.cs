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
        public void GetWordToCheck_ObtainWordForCounting_Word()
        {
            string testWord = "cat";
            string testSentence = "cat";
            RepeatCounter newCounter = new RepeatCounter(testWord, testSentence);
            int result = newCounter.GetFrequency();
            Assert.AreEqual(0, newCounter.GetFrequency());
        }

        [TestMethod]
        public void RepeatCounter_WordAndSentenceMatch_WordsMatch()
        {
            string testWord = "cat";
            string testSentence = "cat";
            RepeatCounter newCounter = new RepeatCounter("cat", "cat");
            Assert.AreEqual(testWord, testSentence);
        }

        [TestMethod]
        public void SentenceToWords_SplitWordsToCharArray_SentenceWords()
        {
            string userSentence = "the cat";
            string[] splitSentenceLetters = new string[] { "the", "cat" };
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            string[] result = newCounter.SentenceToWords(userSentence);
            CollectionAssert.AreEqual(splitSentenceLetters, result);
        }

        [TestMethod]
        public void SentenceToWords_SplitSentenceToWord_SentenceWords()
        {
            string userSentence = "He's a cat";
            string[] splitSentenceLetters = new string[] { "He's", "a", "cat" };
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            string[] result = newCounter.SentenceToWords(userSentence);
            CollectionAssert.AreEqual(splitSentenceLetters, result);
        }

        [TestMethod]
        public void ReplacePunctuation_RemovesPunctuationFromSentence_NoPunctuation()
        {
            string userSentence = "He's a cat!";
            string sentenceNoPunc = "He's a cat ";
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            string result = newCounter.ReplacePunctuation(userSentence);
            Assert.AreEqual(sentenceNoPunc, result);
        }


        //[TestMethod]
        //public void CountOccurences_CountsFrequencyOfWord_Frequency()
        //{
        //    string userSentence = "He's a cat";
        //    string userWord = "cat";
        //    RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
        //    int result = newCounter.CountOccurrences(userWord, userSentence);
        //    Assert.AreEqual(1, result);

        //}
    }
}