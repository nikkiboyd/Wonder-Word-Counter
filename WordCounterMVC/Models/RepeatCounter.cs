using System;
using System.Linq;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _wordToCheck;
        private string _sentenceToCheck;

        public RepeatCounter(string wordToCheck, string sentenceToCheck)
        {
            _wordToCheck = wordToCheck;
            _sentenceToCheck = sentenceToCheck;
        }

        public int CountOccurences(string userWord, string userSentence)
        {
            string[] wordArray = userSentence.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!'});
            var findMatches = from word in wordArray
                              where word.ToLower() == userWord.ToLower()
                              select word;
            
            int wordFrequency = findMatches.Count();
            return wordFrequency;
        }
    }
}
