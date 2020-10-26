using LCChallengeSolutions;
using System.Collections.Generic;
using Xunit;

namespace LCChallengeUnitTestProject
{
    public class LCProblem39Test
    {
        [Fact]
        public void CombinationSum_ReturnsList1()
        {
            // Arrange
            int[] candidates = new int[] { 2, 3, 6, 7 };
            var sut = new LCProblem39();

            // Act
            var result = sut.CombinationSum(candidates, 7);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            combination.Add(new List<int>(new int[] { 2, 2, 3 }));
            combination.Add(new List<int>(new int[] { 7 }));

            Assert.Equal(combination, result);
        }

        [Fact]
        public void CombinationSum_ReturnsList2()
        {
            // Arrange
            int[] candidates = new int[] { 2 };
            var sut = new LCProblem39();

            // Act
            var result = sut.CombinationSum(candidates, 1);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            Assert.Equal(combination, result);
        }

        [Fact]
        public void CombinationSum_ReturnsList3()
        {
            // Arrange
            int[] candidates = new int[] { 1 };
            var sut = new LCProblem39();

            // Act
            var result = sut.CombinationSum(candidates, 1);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            combination.Add(new List<int>(new int[] { 1 }));
            Assert.Equal(combination, result);
        }
    }
}
