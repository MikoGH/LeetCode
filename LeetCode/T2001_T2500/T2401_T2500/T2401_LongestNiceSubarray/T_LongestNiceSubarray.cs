namespace LeetCode.T2001_T2500.T2401_T2500.T2401_LongestNiceSubarray;

public class T_LongestNiceSubarray
{
    public int LongestNiceSubarray(int[] nums)
    {
        var bits = new bool[32];
        var result = 1;

        int l = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            int j = 0;
            while (value > 0)
            {
                if (value % 2 == 0)
                {
                    j++;
                    value >>= 1;
                    continue;
                }

                while (bits[j])
                {
                    var value2 = nums[l];
                    int k = 0;
                    while (value2 > 0)
                    {
                        if (value2 % 2 == 0)
                        {
                            k++;
                            value2 >>= 1;
                            continue;
                        }

                        bits[k] = false;
                        k++;
                        value2 >>= 1;
                    }
                    l++;
                }

                bits[j] = true;
                j++;
                value >>= 1;
            }

            result = Math.Max(result, i - l + 1);
        }

        return result;
    }
}
