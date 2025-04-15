namespace LeetCode.T1501_T2000.T1501_T1600.T1534_CountGoodTriplets;

public class T_CountGoodTriplets
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var result = 0;

        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) > a)
                    continue;

                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[i] - arr[k]) > c)
                        continue;
                    if (Math.Abs(arr[k] - arr[j]) > b)
                        continue;
                    result++;
                }
            }
        }

        return result;
    }
}
