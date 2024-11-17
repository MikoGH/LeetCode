using System.Text.RegularExpressions;

namespace LeetCode.T0001_T0500.T0010_RegularExpressionsMatching;

public class T_RegularExpressionsMatching
{
    public bool IsMatch(string s, string p)
    {
        p = string.Concat("^", p, "$");
        Regex regex = new Regex(p);
        return regex.IsMatch(s);
    }
}
