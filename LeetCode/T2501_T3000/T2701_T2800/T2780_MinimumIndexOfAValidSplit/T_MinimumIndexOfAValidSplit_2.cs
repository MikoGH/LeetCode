namespace LeetCode.T2501_T3000.T2701_T2800.T2780_MinimumIndexOfAValidSplit;

public class T_MinimumIndexOfAValidSplit_2
{
    public int MinimumIndex(IList<int> nums)
    {
        var countByNum = new Dictionary<int, int>();

        var dominantNum = -1;

        for (int i = 0; i < nums.Count; i++)
        {
            if (countByNum.ContainsKey(nums[i]))
                countByNum[nums[i]]++;
            else
                countByNum.Add(nums[i], 1);

            if (countByNum[nums[i]] > (i + 1) >> 1)
            {
                dominantNum = nums[i];
            }
        }

        if (dominantNum == -1)
            return -1;

        var maxCount = countByNum[dominantNum];
        var count = 0;

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == dominantNum)
                count++;

            if ((count > (i + 1) >> 1) && (maxCount - count > (nums.Count - (i + 1)) >> 1))
                return i;
        }

        return -1;
    }
}
