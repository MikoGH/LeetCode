namespace LeetCode.T0501_T1000.T0769_MaxChunksToMakeSorted;

public class T_MaxChunksToMakeSorted
{
    public int MaxChunksToSorted(int[] arr)
    {
        var chunksCount = 0;
        byte maxNum = 0;
        for (byte i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxNum)
                maxNum = (byte)arr[i];
            if (i == maxNum)
            {
                chunksCount++;
                maxNum = i;
                maxNum++;
            }
        }

        return chunksCount;
    }
}
