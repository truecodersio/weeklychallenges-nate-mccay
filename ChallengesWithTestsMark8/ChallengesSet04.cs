using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            {
                return str1.Length;
            }
            else if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            {
                return str2.Length;
            }
            else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length)
            {
                return str3.Length;
            }
            else
            {
                return str4.Length;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength3 + sideLength2 <= sideLength1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            try
            {
                Decimal.Parse(input);
                return true;
            } catch
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            var NULL = 0;
            foreach(object num in objs)
            {
                if(num == null)
                {
                    NULL++;
                }
                else
                {
                    count++;
                }
            }
            if (NULL > count)
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
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (sum == 0)
            {
                return 0;
            }
            return (sum)/count;
        }

        public int Factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            for(int i = number -1; i >= 1; i--)
            {
                number = number * i;
            }
            if (number >= 0)
            {
                return number;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
