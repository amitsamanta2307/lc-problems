using LCChallengeSolutions;
using Xunit;

namespace LCChallengeUnitTestProject
{
    public class LCProblem122Test
    {
        int[] pricesList1 = new int[] { 7, 1, 5, 3, 6, 4 };
        int[] pricesList2 = new int[] { 1, 2, 3, 4, 5 };
        int[] pricesList3 = new int[] { 7, 6, 4, 3, 1 };

        [Fact]
        public void MaxProfit_ForPriceList1_ReturnMaxProfit()
        {
            // Arrange
            var sut = new LCProblem122();

            // Act
            var result = sut.MaxProfit(pricesList1);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void MaxProfit_ForPriceList2_ReturnMaxProfit()
        {
            // Arrange
            var sut = new LCProblem122();

            // Act
            var result = sut.MaxProfit(pricesList2);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void MaxProfit_ForPriceList3_ReturnMaxProfit()
        {
            // Arrange
            var sut = new LCProblem122();

            // Act
            var result = sut.MaxProfit(pricesList3);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
