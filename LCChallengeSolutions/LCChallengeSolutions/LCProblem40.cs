using System;
using System.Collections.Generic;
using System.Linq;

namespace LCChallengeSolutions
{
    public class LCProblem40
    {
        /*
         * Problem 40.
         * Combination Sum II
         * Given a collection of candidate numbers (candidates) and a target number (target), 
         * find all unique combinations in candidates where the candidate numbers sum to target.
         * Each number in candidates may only be used once in the combination.
         * Note: The solution set must not contain duplicate combinations.
         */
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var result = new List<IList<int>>();

            // sort the list
            Array.Sort(candidates);

            Recursion(0, target, candidates, new List<int>(), result);

            return result;
        }

        protected void Recursion(int start, int target, int[] candidates, IList<int> list, IList<IList<int>> result)
        {
            if (target < 0)
                return;

            if (target == 0)
            {
                result.Add(new List<int>(list));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                // avoid duplicates
                if (i > start && candidates[i] == candidates[i - 1])
                    continue;

                list.Add(candidates[i]);
                Recursion(i + 1, target - candidates[i], candidates, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
