namespace LeetCode.T1501_T2000.T1501_T1600.T1550_ThreeConsecutiveOdds;

public class T_ThreeConsecutiveOdds
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        var count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
            {
                count++;
                if (count == 3)
                    return true;
            }
            else
                count = 0;
        }

        return false;
    }
}
