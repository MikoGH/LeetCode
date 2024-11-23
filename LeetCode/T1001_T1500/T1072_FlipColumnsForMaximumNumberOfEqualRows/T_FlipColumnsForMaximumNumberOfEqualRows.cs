namespace LeetCode.T1001_T1500.T1072_FlipColumnsForMaximumNumberOfEqualRows;

public class T_FlipColumnsForMaximumNumberOfEqualRows
{
    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        int m = (int)1e5 + 1;
        var nums = new int[m];
        var maxPos = 0;

        foreach (var row in matrix)
        {
            var p = 1;
            var res = 0;
            var flag = row[0];
            foreach (var col in row)
            {
                res = (res + ((col + flag) % 2) * p) % m;
                p = (p << 1) % m;
            }
            nums[res]++;
            if (nums[res] > nums[maxPos])
                maxPos = res;
        }

        return nums[maxPos];
    }
}
