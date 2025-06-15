namespace LeetCode.T2501_T3000.T2501_T2600.T2566_MaximumDifferenceByRemappingADigit;

public class T_MaximumDifferenceByRemappingADigit
{
    public int MinMaxDifference(int num)
    {
        var s = num.ToString();

        var minReplace = s[0];
        var maxReplace = s[0];
        var i = 0;
        while (maxReplace == '9' && i < s.Length)
        {
            maxReplace = s[i++];
        }

        return int.Parse(s.Replace(maxReplace, '9')) - int.Parse(s.Replace(minReplace, '0'));
    }
}
