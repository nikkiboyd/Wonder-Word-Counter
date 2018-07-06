using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterMVC.Models;

namespace WordCounterTests
{
    [TestClass]
    public class RepeatCounterTests
    {

        [TestMethod]
        public void CountOccurences_FindMatchesAndCount_Frequency()
        {
            string userWord = "cat";
            string userSentence = "the cat is a cat";
            int expectedFrequency = 2;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }

        [TestMethod]
        public void CountOccurences_DoesNotIncludePluralVersion_Frequency()
        {
            string userWord = "cat";
            string userSentence = "Cats are my favorite animal.";
            int expectedFrequency = 0;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }

        [TestMethod]
        public void CountOccurences_FindMatchesWithCaseSensitivity_Frequency()
        {
            string userWord = "cat";
            string userSentence = "Cat people are my kind of people.";
            int expectedFrequency = 1;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }

        [TestMethod]
        public void CountOccurences_TestSentenceWithPunctuation_Frequency()
        {
            string userWord = "cat";
            string userSentence = "What a beautiful cat!";
            int expectedFrequency = 1;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }

        [TestMethod]
        public void CountOccurrences_TestLongSentenceForAccuracy_Frequency()
        {
            string userWord = "Lorem";
            string userSentence = "Lorem ipsum dolor sit amet, Lorem Lorem Lorem Lorem Lorem Lorem Lorem Lorem Lorem Lorem consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            int expectedFrequency = 15;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }

        [TestMethod]
        public void CountOccurrences_FindMatchesInAllCaps_Frequency()
        {
            string userWord = "cat";
            string userSentence = "Watch out for the CAT!";
            int expectedFrequency = 1;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }

        [TestMethod]
        public void CountOccurrences_DoesNotFindMatchInMiddleOfWord_Frequency()
        {
            string userWord = "cat";
            string userSentence = "I ordered some catering.";
            int expectedFrequency = 0;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }

        [TestMethod]
        public void CountOccurences_DoesNotIncludeDashedWords_Frequency()
        {
            string userWord = "cat";
            string userSentence = "My kitty-cat Santa Claws is an alley-cat.";
            int expectedFrequency = 0;
            RepeatCounter newCounter = new RepeatCounter(userWord, userSentence);
            int result = newCounter.CountOccurrences();
            Assert.AreEqual(expectedFrequency, result);
        }
    }
}
