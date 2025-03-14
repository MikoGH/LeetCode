namespace LeetCode.T0501_T1000.T0801_T0900.T0873_LengthOfLongestFibonacciSubsequence;

public class T_LengthOfLongestFibonacciSubsequence
{
    public int LenLongestFibSubseq(int[] arr)
    {
        var result = 0;
        var indexByValue = new Dictionary<int, int>(arr.Length);
        var dp = new int[arr.Length][];

        for (int i = 0; i < arr.Length; i++)
        {
            indexByValue.Add(arr[i], i);
            dp[i] = new int[arr.Length];

            for (int j = 0; j < i; j++)
            {
                var difference = arr[i] - arr[j];

                if (difference >= arr[j] || !indexByValue.ContainsKey(difference))
                {
                    dp[j][i] = 2;
                    continue;
                }

                var index = indexByValue[difference];

                dp[j][i] = dp[index][j] + 1;
                if (dp[j][i] > result)
                    result = dp[j][i];
            }
        }

        return result;
    }
}
