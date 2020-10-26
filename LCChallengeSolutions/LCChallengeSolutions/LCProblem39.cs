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
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> list = new List<int>();

            Recursion(0, target, 0, candidates, list, result);
            
            return result;
        }

        protected void Recursion(int start, int target, int sum, int[] candidates, IList<int> list, IList<IList<int>> result)
        {
            if (sum > target)
                return;

            if (sum == target)
            {
                result.Add(new List<int>(list));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                list.Add(candidates[i]);
                Recursion(i, target, sum + candidates[i], candidates, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
