using System;
using System.Collections.Generic;
using System.Text;

namespace LCChallengeSolutions
{
    public class LCProblem216
    {
        /*
         * Problem 216.
         * Combination Sum III
         * Find all valid combinations of k numbers that sum up to n such that the following conditions are true:
         *      1. Only numbers 1 through 9 are used.
         *      2. Each number is used at most once.
         * Return a list of all possible valid combinations. The list must not contain the same combination twice, 
         * and the combinations may be returned in any order.
         */
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var result = new List<IList<int>>();

            Recursion(1, n, k, new List<int>(), result);

            return result;
        }

        protected void Recursion(int start, int target, int k, IList<int> combination, IList<IList<int>> result)
        {
            if (target < 0)
                return;

            if (target == 0 && combination.Count == k)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = start; i < 10; i++)
            {
                // avoid duplicates
                if (i > start && i == i - 1)
                    continue;

                combination.Add(i);
                Recursion(i + 1, target - i, k, combination, result);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
