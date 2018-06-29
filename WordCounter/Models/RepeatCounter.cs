using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _wordToCheck;
        private List<string> _sentenceToCheck;
        private List<string> _verifiedMatches;

        public RepeatCounter(string wordToCheck, List<string> sentenceToCheck)
        {
            _wordToCheck = wordToCheck;
            _sentenceToCheck = sentenceToCheck;
        }

        public string GetWordToCheck()
        {
            return _wordToCheck;
        }


    }
}
