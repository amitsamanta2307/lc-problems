using System;
using System.Collections.Generic;
using System.Text;

namespace LCChallengeSolutions
{
    public class LCProblem1007
    {
        /*
         * Problem 1007
         * Minimum Domino Rotations For Equal Row
         * In a row of dominoes, A[i] and B[i] represent the top and bottom halves of the ith domino.
         * (A domino is a tile with two numbers from 1 to 6 - one on each half of the tile.)
         * We may rotate the ith domino, so that A[i] and B[i] swap values.
         * Return the minimum number of rotations so that all the values in A are the same, or all the values in B are the same.
         * If it cannot be done, return -1.
         */

        public int MinDominoRotations(int[] A, int[] B)
        {
            int result = Math.Min(GetMinimumRotations(A[0], A, B), GetMinimumRotations(A[0], B, A));
            result = Math.Min(result, GetMinimumRotations(A[0], A, B));
            result = Math.Min(result, GetMinimumRotations(A[0], B, A));

            return result == Int32.MaxValue ? -1 : result;
        }

        protected int GetMinimumRotations(int target, int[] A, int[] B)
        {
            int minSwaps = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != target && B[i] != target)
                {
                    return Int32.MaxValue;
                }
                else if (A[i] != target)
                {
                    minSwaps++;
                }
            }

            return minSwaps;
        }
    }
}
