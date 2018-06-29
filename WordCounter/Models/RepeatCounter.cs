using System;
using System.Collections.Generic;
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

        public string GetWordToCheck()
        {
            return _wordToCheck;
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

        //public string CountOccurences(string userWord, string userSentences)
        //{
        //    string wordToCheck = userWord;
        //    string sentenceToCheck = userSentences;
        //    ReplacePunctuation(userSentences);
        //    SentenceToWords(userSentences);

        //    foreach (string wordToCheck in string sentenceToCheck)
        //    {
        //        return userWord;
        //    }
        //}

        public int CountOccurrences(string userWord, string userSentence)
        {
            int frequency = 0;
            int i = 0;
            while ((i = userWord.IndexOf(userSentence, i, StringComparison.CurrentCulture)) != -1)
            {
                i += userSentence.Length;
                frequency++;
            }
            return frequency;
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

