namespace LeetCode.T0501_T1000.T0701_T0800.T0796_RotateString;

public class T_RotateString_2
{
    public bool RotateString(string s, string goal)
    {
        string s2 = string.Concat(s, s);
        if (s2.Contains(goal))
            return true;
        return false;
    }
}
