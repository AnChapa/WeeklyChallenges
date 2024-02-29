using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            bool divisible = false;
            startNumber++;
            while(divisible != true)
            {
                if (startNumber % n == 0)
                {
                    return startNumber;
                    divisible = true;
                }
                startNumber++;
            }
            return n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business busuiness in businesses)
            {
                if (busuiness.TotalRevenue == 0.0)
                    busuiness.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
                return false;

            int hold = numbers[0];
            foreach(int num in numbers)
            {
                if(num >= hold)
                    hold = num;
                else
                    return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            
            if (numbers == null || numbers.Length == 0)
                return 0;

            int sum = 0;
            int hold = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if(hold % 2 == 0)
                    sum += numbers[i];
                hold = numbers[i];
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";

            string sentence = "";

            foreach(string word in words)
            {
                if (word.Trim() == "")
                    sentence += "";
                else if (Array.LastIndexOf(words, word) == words.Length - 1)
                    sentence += $"{word.Trim()}.";
                else
                    sentence += $"{word.Trim()} ";
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
                return new double[0];

            double[] result = new double[elements.Count / 4];
            int count = 0;

            if(elements.Count / 4 > 0)
                for (int i = 3; i < elements.Count; i += 4)
                {
                    result.SetValue(elements[i], count);
                    count++;
                }

            return result;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int numIndex1 = 0; numIndex1 < nums.Length; numIndex1++)
            {
                for (int numIndex2 = 0; numIndex2 < nums.Length;numIndex2++)
                {
                    if(numIndex1 != numIndex2)
                    {
                        if (nums[numIndex1] + nums[numIndex2] == targetNumber)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
