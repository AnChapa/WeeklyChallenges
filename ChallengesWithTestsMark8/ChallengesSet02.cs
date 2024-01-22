using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            char lowerLetter = char.ToLower(c);
            List<char> letterList = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();

            return letterList.Contains(lowerLetter);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            { 
                return 0; 
            }
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            char[] str1Array = str1.ToCharArray();
            char[] str2Array = str2.ToCharArray();
            if(str1Array.Length <= str2Array.Length)
            {
                return str1Array.Length;
            }
            return str2Array.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                if(IsNumberEven(num))
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }
            int sum = 0;
            foreach(int num in numbers)
            {
                if(IsNumberOdd(num))
                {
                    sum += num;
                }
            }
            return IsNumberOdd(sum);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0)
            {
                return (number) / 2;
            }
            return 0;
        }
    }
}
