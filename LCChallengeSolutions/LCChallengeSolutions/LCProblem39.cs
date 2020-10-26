using System;
using System.Collections.Generic;
using System.Text;

namespace LCChallengeSolutions
{
    public class LCProblem39
    {
        /*
         * Problem 39.
         * Combination Sum
         * Given an array of distinct integers candidates and a target integer target, 
         * return a list of all unique combinations of candidates where the chosen numbers sum to target.
         * You may return the combinations in any order.
         * The same number may be chosen from candidates an unlimited number of times.
         * Two combinations are unique if the frequency of at least one of the chosen numbers is different.
         * It is guaranteed that the number of unique combinations that sum up to target
         * is less than 150 combinations for the given input.
         */
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();

            Recursion(0, target, candidates, new List<int>(), result);
            
            return result;
        }

        protected void Recursion(int start, int target, int[] candidates, IList<int> combination, IList<IList<int>> result)
        {
            if (target < 0)
                return;

            if (target == 0)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                combination.Add(candidates[i]);
                Recursion(i, target - candidates[i], candidates, combination, result);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
