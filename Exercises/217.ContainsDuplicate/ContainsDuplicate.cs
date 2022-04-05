using System;

namespace Exercises._217.ContainsDuplicate
{
    public class Solution 
    {
        public static bool ContainsDuplicateNumbers(int[] nums) {

            Array.Sort(nums);

            for(var i = 0; i < nums.Length-1; i++)
            {
                if(nums[i].Equals(nums[i+1])) 
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}