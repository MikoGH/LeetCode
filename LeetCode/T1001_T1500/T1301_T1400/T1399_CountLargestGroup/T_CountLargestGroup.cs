namespace LeetCode.T1001_T1500.T1301_T1400.T1399_CountLargestGroup;

public class T_CountLargestGroup
{
    public int CountLargestGroup(int n)
    {
        var sums = new int[40];
        var maxCount = 0;
        var countMaxSum = 0;

        for (int i = 1; i <= n; i++)
        {
            var sum = 0;
            var num = i;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            sums[sum]++;

            if (sums[sum] > maxCount)
            {
                maxCount = sums[sum];
                countMaxSum = 1;
            }
            else if (sums[sum] == maxCount)
            {
                countMaxSum++;
            }
        }

        return countMaxSum;
    }
}
