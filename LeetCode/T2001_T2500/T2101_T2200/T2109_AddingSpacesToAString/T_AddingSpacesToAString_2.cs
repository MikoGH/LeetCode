using System.Text;

namespace LeetCode.T2001_T2500.T2101_T2200.T2109_AddingSpacesToAString;

public class T_AddingSpacesToAString_2
{
    public string AddSpaces(string s, int[] spaces)
    {
        StringBuilder stringBuilder = new StringBuilder(s.Length + spaces.Length);
        int i = 0;
        for (int j = 0; j < s.Length; j++)
        {
            if (i < spaces.Length && spaces[i] == j)
            {
                stringBuilder.Append(' ');
                i++;
            }
            stringBuilder.Append(s[j]);
        }
        return stringBuilder.ToString();
    }
}
