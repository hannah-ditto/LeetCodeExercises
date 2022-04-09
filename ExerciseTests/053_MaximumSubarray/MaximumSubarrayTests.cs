//Given an integer array nums, return true if any value appears at least twice
// in the array, and return false if every element is distinct.

using Exercises._053_MaximumSubarray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseTests._053_MaximumSubarray
{
    [TestClass]
    public class MaximumSubarrayTest
    {
        [DataTestMethod]
        [DataRow(new []{-2,1,-3,4,-1,2,1,-5,4}, 6)]
        [DataRow(new []{5,4,-1,7,8}, 23)]
        [DataRow(new []{1},1)]
        [TestMethod]
        public void FindMaximumSubarray_ReturnsSumOfLargestContiguousSubarray(int[] arrayToCheck, int sumOfSubArray)
        {
            // Arrange
            int[] testArr = arrayToCheck;

            // Act
            int maximumSubArrSum = MaximumSubarray.FindMaximumSubarray(testArr);

            // Assert
            Assert.AreEqual(sumOfSubArray, maximumSubArrSum);

        }
    }
}