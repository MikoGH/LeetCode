namespace LeetCode.T1501_T2000.T1701_T1800.T1717_MaximumScoreFromRemovingSubstrings;

public class T_MaximumScoreFromRemovingSubstrings
{
    public int MaximumGain(string s, int x, int y)
    {
        var smb1 = 'a';
        var smb2 = 'b';
        if (y > x)
        {
            (smb1, smb2) = (smb2, smb1);
            (x, y) = (y, x);
        }
        var count1 = 0;
        var count2 = 0;

        var result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (smb1 == s[i])
            {
                count1++;
            }
            else if (smb2 == s[i])
            {
                if (count1 > 0)
                {
                    result += x;
                    count1--;
                }
                else
                    count2++;
            }
            else
            {
                result += Math.Min(count1, count2) * y;
                count1 = 0;
                count2 = 0;
            }
        }

        result += Math.Min(count1, count2) * y;

        return result;
    }
}
