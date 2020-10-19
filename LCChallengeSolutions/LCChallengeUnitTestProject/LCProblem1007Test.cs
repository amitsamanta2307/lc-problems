using LCChallengeSolutions;
using Xunit;

namespace LCChallengeUnitTestProject
{
    public class LCProblem1007Test
    {
        [Fact]
        public void MinDominoRotations_ForDominos_ReturnMinSwaps()
        {
            // Arrange
            int[] A = new int[] { 2, 1, 2, 4, 2, 2 };
            int[] B = new int[] { 5, 2, 6, 2, 3, 2 };
            var sut = new LCProblem1007();

            // Act
            var result = sut.MinDominoRotations(A, B);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void MinDominoRotations_ForDominos_ReturnNegativeOne()
        {
            // Arrange
            int[] A = new int[] { 3, 5, 1, 2, 3 };
            int[] B = new int[] { 3, 6, 3, 3, 4 };
            var sut = new LCProblem1007();

            // Act
            var result = sut.MinDominoRotations(A, B);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}
