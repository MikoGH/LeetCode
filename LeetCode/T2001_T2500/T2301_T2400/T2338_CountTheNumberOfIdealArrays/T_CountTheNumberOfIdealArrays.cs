namespace LeetCode.T2001_T2500.T2301_T2400.T2338_CountTheNumberOfIdealArrays;

public class T_CountTheNumberOfIdealArrays
{
    int mod = (int)1e9 + 7;
    public int IdealArrays(int n, int maxValue)
    {
        var prevNums = new int[maxValue + 1];

        for (int i = 1; i <= maxValue; i++)
        {
            prevNums[i] = 1;
        }

        for (int i = 0; i < n - 1; i++)
        {
            var nums = new int[maxValue + 1];

            for (int j = 1; j <= maxValue; j++)
            {
                var num = j;
                while (num <= maxValue)
                {
                    nums[num] = (nums[num] + prevNums[j]) % mod;
                    num += j;
                }
            }

            prevNums = nums;
        }

        var sum = 0;
        for (int i = 1; i <= maxValue; i++)
        {
            sum = (sum + prevNums[i]) % mod;
        }

        return sum;
    }
}
