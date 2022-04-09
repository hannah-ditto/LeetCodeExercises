using System;

namespace Exercises._053_MaximumSubarray
{
    public static class MaximumSubarray
    {
        public static int FindMaximumSubarray(int[] incomingArr)
        {
            int largestSum = 0;
            int runningSum = 0;
            
            for (var i = 0; i < incomingArr.Length; i++)
            {
                int arrNum = incomingArr[i];

                runningSum = Math.Max(runningSum+=arrNum, arrNum);

                if (i == 0)
                    largestSum = runningSum;

                if (runningSum > largestSum)
                    largestSum = runningSum;
            }
            return largestSum;
        }
    }
}