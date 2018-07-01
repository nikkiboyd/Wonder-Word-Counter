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
            string testSentence = "the cat is happy";
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

        //[TestMethod]
        //public void SentenceToWords_SplitSentenceToWord_SentenceWords()
        //{
        //    string userSentence = "He's a cat";
        //    string[] splitSentenceLetters = new string[] { "He's", "a", "cat" };
        //    RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
        //    string[] result = newCounter.SentenceToWords(userSentence);
        //    CollectionAssert.AreEqual(splitSentenceLetters, result);
        //}

        [TestMethod]
        public void ReplacePunctuation_RemovesPunctuationFromSentence_NoPunctuation()
        {
            string userSentence = "He's a cat!";
            string sentenceNoPunc = "He's a cat ";
            RepeatCounter newCounter = new RepeatCounter("cat", userSentence);
            string result = newCounter.ReplacePunctuation(userSentence);
            Assert.AreEqual(sentenceNoPunc, result);
        }

        [TestMethod]
        public void PrepareWord_PrepareWordForSearch_SplitWord()
        {
            string userSentence = "He's a cat";
            string userWord = "cat";
            string preparedWord = " cat ";
            Console.WriteLine(preparedWord);
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            string result = newCounter.PrepareWord(userWord);
            Assert.AreEqual(preparedWord, result);
        }

        [TestMethod]
        public void TotalOccurrences_CountsTotalWordOccurrences_NumberOfTimes()
        {
            string userSentence = "cat cat cat";
            string userWord = "cat";
            List<int> listOfOccurrences = new List<int>{ 1, 1, 1 };
            int totalOccurences = 3;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.TotalOccurrences(listOfOccurrences);
            Assert.AreEqual(totalOccurences, result);
        }

        [TestMethod]
        public void CountOccurences_CountsEachWordOccurrences_IntFinalAnswer()
        {
            string userSentence = "cat";
            string userWord = "cat";
            int totalOccurences = 1;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences(userWord, userSentence);
            Assert.AreEqual(totalOccurences, result);
        }
    }
}
