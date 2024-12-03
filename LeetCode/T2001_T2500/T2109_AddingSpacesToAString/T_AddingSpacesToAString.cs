using System.Text;

namespace LeetCode.T2001_T2500.T2109_AddingSpacesToAString;

public class T_AddingSpacesToAString
{
    public string AddSpaces(string s, int[] spaces)
    {
        StringBuilder stringBuilder = new StringBuilder(s);
        for (int i = 0; i < spaces.Length; i++)
        {
            stringBuilder.Insert(spaces[i] + i, ' ');
        }
        return stringBuilder.ToString();
    }
}
