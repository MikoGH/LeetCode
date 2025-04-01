namespace LeetCode.T2501_T3000.T2801_T2900.T2818_ApplyOperationsToMaximizeScore;

public class T_ApplyOperationsToMaximizeScore
{
    //const int mod = (int)1e9 + 7;

    //public int MaximumScore(IList<int> nums, int k)
    //{
    //    var primeScores = new int[(int)1e5 + 1];
    //    for (int i = 2; i < primeScores.Length; i++)
    //    {
    //        if (primeScores[i] > 0)
    //            continue;

    //        for (int j = i; j < primeScores.Length; j += i)
    //        {
    //            primeScores[j]++;
    //        }
    //    }

    //    var numsPrimeScores = new int[nums.Count];
    //    for (int i = 0; i < nums.Count; i++)
    //    {
    //        numsPrimeScores[i] = primeScores[nums[i]];
    //    }

    //    var orderedNums = Enumerable.Range(0, nums.Count)
    //        .Select(i => (Num: nums[i], Index: i))
    //        .OrderByDescending(x => x.Num)
    //        .ToList();

    //    long result = 1;
    //    var count = 0;

    //    var orderedNumsIndex = 0;

    //    while (count < k)
    //    {
    //        var numIndex = orderedNums[orderedNumsIndex++].Index;
    //        var numScore = numsPrimeScores[numIndex];

    //        var r = numIndex;
    //        while (r + 1 < nums.Count && numsPrimeScores[r + 1] <= numScore)
    //        {
    //            r++;
    //        }

    //        var l = numIndex;
    //        while (l - 1 >= 0 && numsPrimeScores[l - 1] < numScore)
    //        {
    //            l--;
    //        }

    //        long curCount = (r - numIndex + 1) * (numIndex - l + 1); 
    //        if (curCount > k - count)
    //            curCount = k - count;

    //        result = MultiplyByPow(result, nums[numIndex], curCount) % mod;
    //        count += (int)curCount;
    //    }

    //    return (int)result;
    //}

    //private long MultiplyByPow(long result, long x, long pow)
    //{
    //    while (pow > 0)
    //    {
    //        if (pow % 2 == 1)
    //            result = (result * x) % mod;
    //        x = (x * x) % mod;
    //        pow >>= 1;
    //    }

    //    return result;
    //}
}
