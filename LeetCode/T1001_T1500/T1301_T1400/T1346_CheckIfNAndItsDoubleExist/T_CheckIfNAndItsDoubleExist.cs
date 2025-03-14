namespace LeetCode.T1001_T1500.T1301_T1400.T1346_CheckIfNAndItsDoubleExist;

public class T_CheckIfNAndItsDoubleExist
{
    public bool CheckIfExist(int[] arr)
    {
        int shift = (int)10e3 + 1;
        int size = shift * 2;
        var nums = new bool[size];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] * 2 + shift < size && nums[arr[i] * 2 + shift])
                return true;

            if (arr[i] % 2 == 0 && arr[i] / 2 + shift >= 0 && nums[arr[i] / 2 + shift])
                return true;

            nums[arr[i] + shift] = true;
        }

        return false;
    }
}
