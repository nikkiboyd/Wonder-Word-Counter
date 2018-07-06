using System;
using System.Linq;

namespace WordCounterMVC.Models
{
    public class RepeatCounter
    {
        private string _wordToCheck;
        private string _sentenceToCheck;
        private static int _occurrences;

        public RepeatCounter(string wordToCheck, string sentenceToCheck)
        {
            _wordToCheck = wordToCheck;
            _sentenceToCheck = sentenceToCheck;

        }

        public void SetOccurrences(int occurrences)
        {
            _occurrences = occurrences;
        }

        public int GetOccurrences()
        {
            return _occurrences;
        }

        public int CountOccurrences(string userWord, string userSentence)
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
