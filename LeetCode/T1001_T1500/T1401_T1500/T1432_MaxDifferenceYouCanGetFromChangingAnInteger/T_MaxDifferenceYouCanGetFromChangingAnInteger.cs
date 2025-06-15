namespace LeetCode.T1001_T1500.T1401_T1500.T1432_MaxDifferenceYouCanGetFromChangingAnInteger;

public class T_MaxDifferenceYouCanGetFromChangingAnInteger
{
    public int MaxDiff(int num)
    {
        var s = num.ToString();

        var minReplace = s[0];
        var maxReplace = s[0];
        var i = 0;
        while (maxReplace == '9' && i < s.Length)
        {
            maxReplace = s[i++];
        }
        var j = 0;
        while ((minReplace == '1' || minReplace == '0') && j < s.Length)
        {
            minReplace = s[j++];
        }
        if (minReplace == s[0])
            return int.Parse(s.Replace(maxReplace, '9')) - int.Parse(s.Replace(minReplace, '1'));
        else
            return int.Parse(s.Replace(maxReplace, '9')) - int.Parse(s.Replace(minReplace, '0'));
    }
}
