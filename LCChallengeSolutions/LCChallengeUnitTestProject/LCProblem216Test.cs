using LCChallengeSolutions;
using System.Collections.Generic;
using Xunit;

namespace LCChallengeUnitTestProject
{
    public class LCProblem216Test
    {
        [Fact]
        public void CombinationSum_ReturnsList1()
        {
            // Arrange
            int k = 3;
            int n = 7;
            var sut = new LCProblem216();

            // Act
            var result = sut.CombinationSum3(k, n);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            combination.Add(new List<int>(new int[] { 1, 2, 4 }));

            Assert.Equal(combination, result);
        }

        [Fact]
        public void CombinationSum_ReturnsList2()
        {
            // Arrange
            int k = 3;
            int n = 9;
            var sut = new LCProblem216();

            // Act
            var result = sut.CombinationSum3(k, n);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            combination.Add(new List<int>(new int[] { 1, 2, 6 }));
            combination.Add(new List<int>(new int[] { 1, 3, 5 }));
            combination.Add(new List<int>(new int[] { 2, 3, 4 }));

            Assert.Equal(combination, result);
        }

        [Fact]
        public void CombinationSum_ReturnsList3()
        {
            // Arrange
            int k = 4;
            int n = 1;
            var sut = new LCProblem216();

            // Act
            var result = sut.CombinationSum3(k, n);

            // Assert
            List<List<int>> combination = new List<List<int>>();

            Assert.Equal(combination, result);
        }

        [Fact]
        public void CombinationSum_ReturnsList4()
        {
            // Arrange
            int k = 9;
            int n = 45;
            var sut = new LCProblem216();

            // Act
            var result = sut.CombinationSum3(k, n);

            // Assert
            List<List<int>> combination = new List<List<int>>();
            combination.Add(new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));

            Assert.Equal(combination, result);
        }
    }
}
