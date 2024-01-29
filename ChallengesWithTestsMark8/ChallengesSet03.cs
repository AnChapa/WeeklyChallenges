using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(int i = 0; i < vals.Length; i ++)
            {
                if (vals[i] == false)
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;

            int sumOdds = 0;
            foreach( int num in numbers)
            {
                if (num % 2 != 0)
                    sumOdds += num;
            }
            return (sumOdds % 2 != 0 ? true : false);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            List<char> splitString = password.ToCharArray().ToList();
            bool lower = false;
            bool upper = false;
            bool num = false;
            foreach( char c in splitString )
            {
                if(Char.IsUpper(c))
                    upper = true;
                if(Char.IsLower(c))
                    lower = true;
                if(char.IsDigit(c))
                    num = true;
            }
            return lower == true && upper == true && num == true;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 != 0)
                    odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0;i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
