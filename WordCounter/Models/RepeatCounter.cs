using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _wordToCheck;
        private string _sentenceToCheck;
        private int _frequency;

        public RepeatCounter(string wordToCheck, string sentenceToCheck)
        {
            _wordToCheck = wordToCheck;
            _sentenceToCheck = sentenceToCheck;
        }

        public string GetWordToCheck()
        {
            return _wordToCheck;
        }

        public void SetWordToCheck(string userWord)
        {
            _wordToCheck = userWord;
        }

        public string GetSentenceToCheck()
        {
            return _sentenceToCheck;
        }

        public void SetSentenceToCheck(string userSentence)
        {
            _sentenceToCheck = userSentence;
        }

        public int GetFrequency()
        {
            return _frequency;
        }

        public void SetFrequency(int wordOccurences)
        {
            _frequency = wordOccurences;
        }

        //public char[] SplitWordToCheck(string wordToCheck)
        //{
        //    string wordToSplit = wordToCheck;
        //    char[] wordLetters = wordToSplit.ToCharArray();
        //    return wordLetters;
        //}

        //public char[] SplitWordToCheck(string wordToCheck)
        //{
        //    string wordToSplit = wordToCheck;
        //    char[] wordLetters = wordToSplit.ToCharArray();
        //    return wordLetters;
        //}

        public string[] SentenceToWords(string userSentence)
        {
            string[] sentenceWords = userSentence.Split(' ');
            return sentenceWords;
        }

        public string ReplacePunctuation(string userSentence)
        {
            userSentence = userSentence.Replace('.', ' ');
            userSentence = userSentence.Replace(',', ' ');
            userSentence = userSentence.Replace(';', ' ');
            userSentence = userSentence.Replace('!', ' ');
            userSentence = userSentence.Replace('?', ' ');
            userSentence = userSentence.Replace(':', ' ');
            return userSentence;
        }
    }
}
        //public int CountOccurences(string userWord, string userSentence)
        //{
            
        //string sentence = userSentence;
        //string wordToSearch = userWord;

        //    string[] wordArray = userSentence.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!', '-'}, StringSplitOptions.RemoveEmptyEntries);
        //    var findMatches = from word in wordArray
        //                      where word.ToLowerInvariant() == wordToSearch.ToLowerInvariant()
        //                      select word;
        //    int wordFrequency = findMatches.Count();
        //    return wordFrequency;
        //}

