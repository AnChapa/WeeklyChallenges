using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null || words.Count() == 0) 
                return false;

            string[] newWords = words.ToArray();

            if (ignoreCase == true)
            {
                for (int i = 0; i < newWords.Length; i++)
                {
                    if (newWords[i] != null)
                        newWords[i] = newWords[i].ToLower();
                }
            }

            foreach (string hold in newWords)
            {
                if(hold == word)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if(num == null)
                return false;
            else if(num < 2)
                return false;
            else if( num == 2) 
                return true;
            else if(num % 2 ==0)
                return false;
            else
            {
                double max_div = Math.Sqrt(num) + 1;
                for (int i = 3;i < max_div;i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if(str == null || str == "")
                return -1;
            if (str.Length == 1)
                return 0;

            int? holdIndex = null;
            List<char> charList = str.ToCharArray().ToList();

            for(int i = 0;i < charList.Count; i++)
            {
                if (charList.LastIndexOf(charList[i]) == charList.IndexOf(charList[i]))
                    holdIndex = i;
            }

            if (holdIndex == null)
                return -1;
            return holdIndex.Value;
            
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxCount = 1;
            int holdCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    holdCount++;
                }
                else
                {
                    if (holdCount > maxCount)
                        maxCount = holdCount;
                    holdCount = 1;
                }
            }

            if (holdCount > maxCount)
                maxCount = holdCount;

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
                return new double[0];

            List<double> resultList = new List<double>();

            for (int i = n-1; i < elements.Count(); i += n)
            {
                resultList.Add(elements[i]);
            }

            return resultList.ToArray<double>();
        }
    }
}
