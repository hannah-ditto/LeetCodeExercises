using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.XPath;

namespace Exercises._001_TwoSum
{
    public static class TwoSum
    {
        public static int[] FindTwoSum(int[] incomingArr, int target)
        {
            int[] answer = new int[2];
            bool foundAnswer = false;

            while (!foundAnswer)
            {
                Dictionary<int, int> reversedDictionary = new Dictionary<int, int>();

                for (int i = 0; i < incomingArr.Length; i++)
                {
                    int startingNum = incomingArr[i];
                    answer[0] = i;
                    int match = target - startingNum;

                    if (reversedDictionary.TryGetValue(match, out int matchingValueIdx))
                    {
                        answer[1] = matchingValueIdx;
                        foundAnswer = true;
                        break; 
                    }

                    reversedDictionary.TryAdd(incomingArr[i], i);
                }
            }
            return answer;
        }
    }
}