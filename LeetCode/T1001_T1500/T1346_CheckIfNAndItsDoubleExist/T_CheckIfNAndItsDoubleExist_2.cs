namespace LeetCode.T1001_T1500.T1346_CheckIfNAndItsDoubleExist;

public class T_CheckIfNAndItsDoubleExist_2
{
    public bool CheckIfExist(int[] arr)
    {
        var nums = new HashSet<int>();

        foreach (int num in arr)
        {
            if (nums.Contains(num << 1) || num % 2 == 0 && nums.Contains(num >> 1))
                return true;

            nums.Add(num);
        }

        return false;
    }
}
