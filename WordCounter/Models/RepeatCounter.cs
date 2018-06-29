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
        }

        public string GetWordToCheck()
        {
            return _wordToCheck;
        }

        public char[] SplitSentence(string userSentence)
        {
            string sentence = userSentence;
            char[] letters = sentence.ToCharArray();
            return letters;

            //for (int i = 0; i < letters.Length; i++)
            //{
            //    char letter = letters[i];
            //}
        }
    }
}
