using LCChallengeSolutions;
using Xunit;

namespace LCChallengeUnitTestProject
{
    public class LCProblem121Test
    {
        int[] pricesList1 = new int[] { 7, 1, 5, 3, 6, 4 };
        int[] pricesList2 = new int[] { 7, 6, 4, 3, 1 };

        [Fact]
        public void MaxProfit_ForPriceList1_ReturnMaxProfit()
        {
            // Arrange
            var sut = new LCProblem121();

            // Act
            var result = sut.MaxProfit(pricesList1);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void MaxProfit_ForPriceList2_ReturnMaxProfit()
        {
            // Arrange
            var sut = new LCProblem121();

            // Act
            var result = sut.MaxProfit(pricesList2);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
