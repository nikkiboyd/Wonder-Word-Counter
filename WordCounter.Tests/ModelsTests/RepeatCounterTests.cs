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

        //[TestMethod]
        //public void SplitWord_SplitMainWordToCharArray_WordLetters()
        //{
        //    string userWord = "cat";
        //    string userSentence = "the cat";
        //    char[] splitWordLetters = new char[] { 'c', 'a', 't' };
        //    RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
        //    char[] result = newCounter.SplitWordToCheck(userWord);
        //    CollectionAssert.AreEqual(splitWordLetters, result);
        //}

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
            string userSentence = "He's a cat.";
            string sentenceNoPunc = "He's a cat ";
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            string result = newCounter.ReplacePunctuation(userSentence);
            Assert.AreEqual(sentenceNoPunc, result);

        }

        //[TestMethod]
        //public void CountOccurences_FindMatchesAndCount_Frequency()
        //{
        //    string userWord = "cat";
        //    string userSentence = "the cat is a cat";
        //    int expectedFrequency = 2;
        //    RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
        //    int result = newCounter.CountOccurences(userWord, userSentence);
        //    Assert.AreEqual(expectedFrequency, result);
        //}
        //[TestMethod]
        //public void CountOccurences_TestSentenceWithPunctuation_Frequency()
        //{
        //    string userWord = "cat";
        //    string userSentence = "What a beautiful cat!";
        //    int expectedFrequency = 1;
        //    RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
        //    int result = newCounter.CountOccurences(userWord, userSentence);
        //    Assert.AreEqual(expectedFrequency, result);
        //}
        //[TestMethod]
        //public void CountOccurences_TestSentenceWithCapitalizationAndPluralization_Frequency()
        //{
        //    string userWord = "cat";
        //    string userSentence = "What a beautiful Cat! Cats are my favorite animal.";
        //    int expectedFrequency = 0;
        //    RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
        //    int result = newCounter.CountOccurences(userWord, userSentence);
        //    Assert.AreEqual(expectedFrequency, result);
        //}
    }
}
