using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _userWord;
        private string _userSentence;

        public RepeatCounter(string userWord, string userSentence)
        {
            _userWord = userWord;
            _userSentence = userSentence;
        }

        public string PrepareSentence(string userSentence)
        {
            userSentence = userSentence.ToLower();
            userSentence = userSentence.Replace('.', ' ');
            userSentence = userSentence.Replace(',', ' ');
            userSentence = userSentence.Replace(';', ' ');
            userSentence = userSentence.Replace('!', ' ');
            userSentence = userSentence.Replace('?', ' ');
            userSentence = userSentence.Replace(':', ' ');
            return userSentence;
        }

        public int TotalOccurrences(List<int> listOfOccurrences)
        {
            int totalOccurrences = listOfOccurrences.Count();
            return totalOccurrences;
        }

        public int CountOccurrences(string userWord, string userSentence)
        {
            List<int> listOfOccurrences = new List<int>();
            userSentence = PrepareSentence(userSentence);
            string[] sentenceToSearch = userSentence.Split();

            foreach (string word in sentenceToSearch)
            {
                if (word == userWord)
                {
                    listOfOccurrences.Add(1);
                }
            }
            return TotalOccurrences(listOfOccurrences);
        }
    }
}
