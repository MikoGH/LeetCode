namespace LeetCode.T1001_T1500.T1422_MaximumScoreAfterSplittingAString;

public class T_MaximumScoreAfterSplittingAString
{
    public int MaxScore(string s)
    {
        var count1 = s.Count<char>(x => x == '1');
        var count0 = 0;
        var result = 0;

        for (var i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '1')
                count1--;
            else
                count0++;

            if (count0 + count1 > result)
                result = count0 + count1;
        }

        return result;
    }
}
