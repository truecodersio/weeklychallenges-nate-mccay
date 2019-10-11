﻿using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var mylist = new List<bool>(vals);
                if (mylist.Contains(false))
                    return true;
                else
                    return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach(int num in numbers)
                if (num % 2 != 0)
                {
                    sum += num;
                }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
                return true;
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length -1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return (dividend/divisor);
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length -1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[]arr = {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99};
            return arr;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}