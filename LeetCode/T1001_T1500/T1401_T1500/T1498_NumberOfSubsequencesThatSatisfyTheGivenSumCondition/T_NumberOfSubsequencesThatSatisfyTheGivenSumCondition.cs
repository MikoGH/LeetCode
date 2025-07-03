namespace LeetCode.T1001_T1500.T1401_T1500.T1498_NumberOfSubsequencesThatSatisfyTheGivenSumCondition;

public class T_NumberOfSubsequencesThatSatisfyTheGivenSumCondition
{
    int mod = (int)1e9 + 7;
    //    public int NumSubseq(int[] nums, int target)
    //    {
    //        var pref = new int[(int)1e6 + 1];

    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            pref[nums[i]]++;
    //        }

    //        for (int i = 1; i < pref.Length; i++)
    //        {
    //            pref[i] = (pref[i] + pref[i - 1]) % mod;
    //        }

    //        int result = 0;

    //        for (int i = 1; i < pref.Length; i++)
    //        {
    //            if (target - i < i)
    //                break;
    //            result = (result + GetSum(pref[target - i] - pref[i - 1] - 1)) % mod;
    //        }

    //        return result;
    //    }

    //    private int GetSum(int value)
    //    {
    //        if (value % 2 == 0)
    //            return (value + 1) * (int)(value >> 1);

    //        return (value + 1) * (int)(value >> 1) + (value >> 1) + 1;
    //    }

    public int NumSubseq(int[] nums, int target)
    {
        Array.Sort(nums);

        int[] pows = new int[nums.Length];
        pows[0] = 1;
        for (int i = 1; i < nums.Length; i++)
            pows[i] = (pows[i - 1] << 1) % mod;

        int left = 0;
        int right = nums.Length - 1;
        int result = 0;

        while (left <= right)
        {
            if (nums[left] + nums[right] <= target)
            {
                result = (result + pows[right - left]) % mod;
                left++;
            }
            else
            {
                right--;
            }
        }

        return result;
    }
}
