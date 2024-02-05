using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    result += number;
                else
                    result -= number;
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 <= 0) || (sideLength2 <= 0) || (sideLength3 <= 0))
                return false;
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
                return true;
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = objs.Count(x => x == null);
            return count > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0 || !numbers.Any(x => x % 2 == 0))
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if(number < 0) 
                throw new ArgumentOutOfRangeException("number");
            if (number == 0)
                return 1;

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
