using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _wordToCheck;
        private string _sentenceToCheck;
        private char[] _splitWords;

        public RepeatCounter(string wordToCheck, string sentenceToCheck)
        {
            _wordToCheck = wordToCheck;
            _sentenceToCheck = sentenceToCheck;
        }

        public string GetWordToCheck()
        {
            return _wordToCheck;
        }

        public char[] SplitWordToCheck(string wordToCheck)
        {
            string wordToSplit = wordToCheck;
            char[] wordLetters = wordToSplit.ToCharArray();
            return wordLetters;
        }

        public char[] SplitSentence(string userSentence)
        {
            string sentence = userSentence;
            char[] sentenceLetters = sentence.ToCharArray();
            return sentenceLetters;
        }
    }
}
