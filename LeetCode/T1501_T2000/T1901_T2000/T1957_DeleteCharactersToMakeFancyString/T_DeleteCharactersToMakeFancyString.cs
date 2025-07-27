using System.Text;

namespace LeetCode.T1501_T2000.T1901_T2000.T1957_DeleteCharactersToMakeFancyString;

public class T_DeleteCharactersToMakeFancyString
{
    public string MakeFancyString(string s)
    {
        var result = new StringBuilder();
        result = result.Append(s[0]);
        if (s.Length > 1)
            result = result.Append(s[1]);

        for (int i = 2; i < s.Length; i++)
        {
            if (s[i] == s[i - 1] && s[i - 1] == s[i - 2])
                continue;

            result = result.Append(s[i]);
        }

        return result.ToString();
    }
}
