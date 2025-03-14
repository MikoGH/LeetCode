namespace LeetCode.T3001_T3500.T3101_T3200.T3152_SpecialArrayII;

public class T_SpecialArrayII
{
    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
        var specialSum = new int[nums.Length];

        for (int i = 1; i < nums.Length; i++)
        {
            specialSum[i] = specialSum[i - 1];
            if ((nums[i] + nums[i - 1]) % 2 == 0)
                specialSum[i]++;
        }

        var answer = new bool[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            answer[i] = specialSum[queries[i][0]] == specialSum[queries[i][1]];
        }

        return answer;
    }
}
