namespace LeetCode.T2001_T2500.T2401_T2500.T2411_SmallestSubarraysWithMaximumBitwiseOR;

public class T_SmallestSubarraysWithMaximumBitwiseOR
{
    public int[] SmallestSubarrays(int[] nums)
    {
        var result = new int[nums.Length];

        var counts = new int[32];
        var j = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            var num = nums[i];
            var bit = 0;
            while (num > 0)
            {
                if (num % 2 == 1)
                    counts[bit]++;
                num >>= 1;
                bit++;
            }

            while (j > i && Check(counts, nums[j]))
            {
                var num2 = nums[j];
                var bit2 = 0;
                while (num2 > 0)
                {
                    if (num2 % 2 == 1)
                        counts[bit2]--;
                    num2 >>= 1;
                    bit2++;
                }
                j--;
            }

            result[i] = j - i + 1;
        }

        return result;
    }

    private bool Check(int[] counts, int num)
    {
        var bit = 0;
        while (num > 0)
        {
            if (num % 2 == 1 && counts[bit] <= 1)
                return false;
            num >>= 1;
            bit++;
        }

        return true;
    }
}
