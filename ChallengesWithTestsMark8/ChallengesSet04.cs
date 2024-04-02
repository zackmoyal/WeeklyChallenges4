using System;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                // if result is even
                if (number % 2 == 0)
                {
                    result += number;
                }
                // if result is odd
                else
                {
                    result -= number;
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minLength = str1.Length;

            if (str2.Length < minLength)
            {
                minLength = str2.Length;
            }

            if (str3.Length < minLength)
            {
                minLength = str3.Length;
            }

            if (str4.Length < minLength)
            { 
                minLength = str4.Length;
            }

            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = number1;

            if (number2 < smallestNumber)
            {
                smallestNumber = number2;
            }

            if (number3 < smallestNumber)
            {
                smallestNumber = number3;
            }

            if (number4 < smallestNumber)
            {
                smallestNumber = number4;
            }

            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool canFormTriangle =
                (sideLength1 + sideLength2 > sideLength3) &&
                (sideLength1 + sideLength3 > sideLength2) &&
                (sideLength2 + sideLength3 > sideLength1);

            return canFormTriangle;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);

            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }

            if (count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            // do this because factorial is not defined for negative numbers
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            // factorial of 0 is defined to be 1
            if (number == 0)
            {
                return 1;
            }

            int result = 1;

            // loop from 1 to the number, multiplying the result by each number in this range
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
