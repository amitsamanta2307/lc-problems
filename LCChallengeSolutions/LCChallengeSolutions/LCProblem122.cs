using System;
using System.Collections.Generic;
using System.Text;

namespace LCChallengeSolutions
{
    public class LCProblem122
    {
        /*
         * Problem Statement
         * Problem 122. 
         * ### Best Time to Buy and Sell Stock II
         * Say you have an array prices for which the ith element is the price of a given stock on day i.
         * Design an algorithm to find the maximum profit. You may complete as many transactions
         * as you like (i.e., buy one and sell one share of the stock multiple times).
         * Note: You may not engage in multiple transactions at the same time (i.e., you must sell
         * the stock before you buy again).
         */
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i-1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }

            return maxProfit;
        }
    }
}
