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
            _occurrences = 0;
        }

        public string GetWord()
        {
            return _wordToCheck;
        }

        public int CountOccurrences()
        {
            string[] wordArray = _sentenceToCheck.Split(new char[] { ' ', '.', ',', ';', ':', '?', '!'});
            var findMatches = from word in wordArray
                              where word.ToLower() == _wordToCheck.ToLower()
                              select word;
            
            _occurrences = findMatches.Count();
            return _occurrences;
        }
    }
}
