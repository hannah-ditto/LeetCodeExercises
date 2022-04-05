//Given an integer array nums, return true if any value appears at least twice
// in the array, and return false if every element is distinct.

using Exercises._217.ContainsDuplicate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseTests._217.ContainsDuplicate
{
    [TestClass]
    public class SolutionTest
    {
        [DataTestMethod]
        [DataRow(new []{1,1,1,3,3,4,3,2,4,2})]
        [DataRow(new []{1,2,3,1})]
        [TestMethod]
        public void ContainsDuplicate_WhenDuplicateExists_ReturnsTrue(int[] arrayToCheck)
        {
            // Arrange
            int[] testArr = arrayToCheck;

            // Act
            bool containsDup = Solution.ContainsDuplicateNumbers(testArr);

            // Assert
            Assert.AreEqual(true, containsDup);

        }

        [DataTestMethod]
        [DataRow(new []{1,100,24,18,-35,2})]
        [DataRow(new []{1,2,3,-1})]
        [DataRow(new []{1,2,3,4})]
        public void ContainsDuplicate_WhenNoDuplicatesExist_ReturnsFalse(int[] arrayToCheck)
        {
            // Arrange
            int[] testArr = arrayToCheck;

            // Act
            bool containsDup = Solution.ContainsDuplicateNumbers(testArr);

            // Assert
            Assert.AreEqual(false, containsDup);
        }

    }
}