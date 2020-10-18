using System;
using System.Collections.Generic;
using System.Text;

namespace LCChallengeSolutions
{
    /*
     * Problem Statement
     * Problem 121. 
     * ### Best Time to Buy and Sell Stock
     * Say you have an array for which the ith element is the price of a given stock on day i.
     * If you were only permitted to complete at most one transaction 
     * (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
     * Note that you cannot sell a stock before you buy one.
     */
    public class LCProblem121
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = Int32.MaxValue;
            int maxProfit = 0;

            // Loop through the list of the prices
            for (int i = 0; i < prices.Length; i++)
            {
                // Buying a stock
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }

                // Selling a stock
                if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
