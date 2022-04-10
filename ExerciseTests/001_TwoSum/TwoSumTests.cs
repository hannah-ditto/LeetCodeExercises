//Given an integer array nums, return true if any value appears at least twice
// in the array, and return false if every element is distinct.

using System;
using System.Collections.Generic;
using System.Linq;
using Exercises._001_TwoSum;
using Exercises._053_MaximumSubarray;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseTests._001_TwoSum
{
    [TestClass]
    public class TwoSumTest
    {
        [DataTestMethod]
        [DataRow(new []{-1,-2,-3,-4,-5}, -8, new []{2,4})]
        [DataRow(new []{2,5,5,11}, 10, new []{1,2})]
        [DataRow(new []{3,3}, 6, new []{0,1})]
        [DataRow(new []{2,7,11,15}, 9, new []{0,1})]
        [DataRow(new []{3,2,4}, 6, new []{1,2})]

        [TestMethod]
        public void FindTwoSum_ReturnsIndicesOfNumWhichEqualTarget(int[] arrayToCheck, int target, int[] answerIndices)
        {
            // Arrange
            int[] testArr = arrayToCheck;

            // Act
            int[] answerArr = TwoSum.FindTwoSum(testArr, target);
            Array.Sort(answerArr);
            
            // Assert
            CheckSum(arrayToCheck, answerArr).Should().Be(target);
            answerIndices.SequenceEqual(answerArr).Should().BeTrue();
           
        }

        private static int CheckSum(int[] arrayToCheck, int[] answerIndices)
        {
            var totalSum = answerIndices.Sum(i => arrayToCheck[i]);

            return totalSum;
        }
    }
}