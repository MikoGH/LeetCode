namespace LeetCode.T2501_T3000.T2948_MakeLexicographicallySmallestArrayBySwappingElements;

public class T_MakeLexicographicallySmallestArrayBySwappingElements
{
    public int[] LexicographicallySmallestArray(int[] nums, int limit)
    {
        var sortedNums = (int[])nums.Clone();
        Array.Sort(sortedNums);

        var groupsByNum = new Dictionary<int, int>();
        var groups = new Dictionary<int, Queue<int>>();

        var groupNum = 0;
        groupsByNum.Add(sortedNums[0], groupNum);
        groups.Add(groupNum, new Queue<int>());
        groups[groupNum].Enqueue(sortedNums[0]);

        for (int i = 1; i < nums.Length; i++)
        {
            if (Math.Abs(sortedNums[i] - sortedNums[i - 1]) > limit)
            {
                groupNum++;
                groups.Add(groupNum, new Queue<int>());
            }

            groupsByNum[sortedNums[i]] = groupNum;
            groups[groupNum].Enqueue(sortedNums[i]);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = groups[groupsByNum[nums[i]]].Dequeue();
        }

        return nums;
    }
}
