using LCChallengeSolutions;
using System.Collections.Generic;
using Xunit;

namespace LCChallengeUnitTestProject
{
    public class LCProblem40Test
    {
        [Fact]
        public void CombinationSum_ReturnsList1()
        {
            // Arrange
            int[] candidates = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            var sut = new LCProblem40();

            // Act
            var result = sut.CombinationSum2(candidates, 8);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            combination.Add(new List<int>(new int[] { 1, 1, 6 }));
            combination.Add(new List<int>(new int[] { 1, 2, 5 }));
            combination.Add(new List<int>(new int[] { 1, 7 }));
            combination.Add(new List<int>(new int[] { 2, 6 }));

            Assert.Equal(combination, result);
        }

        [Fact]
        public void CombinationSum_ReturnsList2()
        {
            // Arrange
            int[] candidates = new int[] { 2, 5, 2, 1, 2 };
            var sut = new LCProblem40();

            // Act
            var result = sut.CombinationSum2(candidates, 5);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            combination.Add(new List<int>(new int[] { 1, 2, 2 }));
            combination.Add(new List<int>(new int[] {5 }));

            Assert.Equal(combination, result);
        }
    }
}
