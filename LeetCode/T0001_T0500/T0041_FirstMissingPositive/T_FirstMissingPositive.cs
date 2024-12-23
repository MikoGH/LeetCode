namespace LeetCode.T0001_T0500.T0041_FirstMissingPositive;

public class T_FirstMissingPositive
{
    public int FirstMissingPositive(int[] nums)
    {
        int i = 0, j = -1;
        while (i < nums.Length || j >= 0 && j < nums.Length)
        {
            if (j < 0 || j >= nums.Length || nums[j] == j + 1)
            {
                j = i++;
                if (j >= 0 && j < nums.Length && nums[j] != j + 1)
                    (j, nums[j]) = (nums[j] - 1, -1);
                continue;
            }
            (j, nums[j]) = (nums[j] - 1, j + 1);
        }

        var minNum = 1;
        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] == -1)
                break;
            minNum++;
        }

        return minNum;
    }
}
