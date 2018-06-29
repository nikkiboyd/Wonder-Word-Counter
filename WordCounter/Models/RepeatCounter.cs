using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _wordToCheck;
        private string _sentenceToCheck;
        private List<string> _splitWords;

        public RepeatCounter(string wordToCheck, string sentenceToCheck)
        {
            _wordToCheck = wordToCheck;
            _sentenceToCheck = sentenceToCheck;
            _splitWords = splitWords;
        }

        public string GetWordToCheck()
        {
            return _wordToCheck;
        }

        public void SplitSentence(string userSentence)
        {
            string sentence = userSentence;
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                _splitWords.Add(word);
            }
        }
    }
}
