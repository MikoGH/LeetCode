using System;

namespace LeetCode.T3001_T3500.T3201_T3300.T3202_FindTheMaximumLengthOfValidSubsequenceII;

public class T_FindTheMaximumLengthOfValidSubsequenceII
{
    public int MaximumLength(int[] nums, int k)
    {
        var rems = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            rems[i] = nums[i] % k;
        }

        var longestSubsequenceLength = 2;

        var remsDict = new Dictionary<int, (int LastPos, int Count)>();

        for (int i = 0; i < rems.Length; i++)
        {
            var lastPos = i;
            for (int j = i + 1; j < rems.Length; j++)
            {
                if (rems[j] == rems[i])
                    lastPos = j;

                if (remsDict.TryAdd(rems[j], (j, 2)))
                    continue;

                var tuple = remsDict[rems[j]];

                if (tuple.LastPos > lastPos)
                    continue;

                var subsequenceLength = tuple.Count + 1;

                if (rems[j] != rems[i])
                    subsequenceLength++;

                remsDict[rems[j]] = (j, subsequenceLength);
            }

            foreach (var key in remsDict.Keys)
            {
                var tuple = remsDict[key];
                var subsequenceLength = tuple.Count;
                if (tuple.LastPos < lastPos)
                    subsequenceLength++;

                if (longestSubsequenceLength < subsequenceLength)
                    longestSubsequenceLength = subsequenceLength;
            }

            remsDict.Clear();
        }

        return longestSubsequenceLength;
    }
}
