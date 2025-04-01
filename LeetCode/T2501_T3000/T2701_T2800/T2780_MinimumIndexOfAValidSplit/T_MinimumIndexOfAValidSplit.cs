namespace LeetCode.T2501_T3000.T2701_T2800.T2780_MinimumIndexOfAValidSplit;

public class T_MinimumIndexOfAValidSplit
{
    //public int MinimumIndex(IList<int> nums)
    //{
    //    var indexByNum = new Dictionary<int, int>();
    //    var countByNum = new Dictionary<int, int>();

    //    var dominantNum = -1;

    //    for (int i = 0; i < nums.Count; i++)
    //    {
    //        if (countByNum.ContainsKey(nums[i]))
    //            countByNum[nums[i]]++;
    //        else
    //            countByNum.Add(nums[i], 1);

    //        if (countByNum[nums[i]] > (i + 1) >> 1)
    //        {
    //            if (!indexByNum.ContainsKey(nums[i]))
    //                indexByNum.Add(nums[i], i);

    //            dominantNum = nums[i];
    //        }
    //    }

    //    var index = indexByNum[dominantNum];
    //    var count = countByNum[dominantNum];

    //    if (count - (((index + 1) >> 1) + 1) <= nums.Count - (indexByNum[dominantNum] + 1))
    //        return -1;

    //    return index;
    //}
}
