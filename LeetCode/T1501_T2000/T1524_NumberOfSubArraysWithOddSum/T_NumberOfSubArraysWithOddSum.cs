namespace LeetCode.T1501_T2000.T1524_NumberOfSubArraysWithOddSum;

public class T_NumberOfSubArraysWithOddSum
{
    const int _mod = (int)1e9 + 7;

    public int NumOfSubarrays(int[] arr)
    {
        var count = 0;
        var sum = 0;
        var countEven = 1;
        var countOdd = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum % 2 == 0)
            {
                count += countOdd;
                countEven++;
            }
            else
            {
                count += countEven;
                countOdd++;
            }

            count %= _mod;
        }

        return count;
    }
}
