namespace LeetCode.T1001_T1500.T1301_T1400.T1394_FindLuckyIntegerInAnArray;

public class T_FindLuckyIntegerInAnArray
{
    public int FindLucky(int[] arr)
    {
        var counts = new int[arr.Max() + 1];

        for (int i = 0; i < arr.Length; i++)
            counts[arr[i]]++;

        var result = -1;

        for (int i = 1; i < counts.Length; i++)
        {
            if (counts[i] == i)
                result = i;
        }

        return result;
    }
}
