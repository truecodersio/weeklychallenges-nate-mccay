using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if(numbers == null)
            {
                return 0;
            }
            for(int i = 0; i < numbers.Length-1;i++)
            {
                if (numbers[i] % 2 ==0)
                {
                    sum +=numbers[1 + i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null)
            {
                return "";
            }
            string s = "";
            foreach(string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    s += word.Trim() + " ";
                }
            }
            if (s.Length == 0)
            {
                return "";
            }
            s = s.Substring(0, s.Length - 1);
            s += ".";
            return s;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            
            List<double> forth = new List<double>();
            if (elements == null)
            {
                return forth.ToArray();
            }
            for (int i = 0;i < elements.Count;i++)
            {
                if(elements[i] % 4 == 0)
                {
                    forth.Add(elements[i]);
                }
            }
            return forth.ToArray();
        }
        
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i<nums.Length;i++)
            {
                for(int j = 0; j<nums.Length;j++)
                {
                    if (i != j)
                    {
                        int sum = nums[i] + nums[j];
                        if (sum == targetNumber)
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
                                                           