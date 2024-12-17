using System.Text;

namespace LeetCode.T2001_T2500.T2182_ConstructStringWithRepeatLimit;

public class T_ConstructStringWithRepeatLimit
{
    public string RepeatLimitedString(string s, int repeatLimit)
    {
        var letters = new int[26];
        StringBuilder sb = new StringBuilder(s.Length);
        for (int k = 0; k < s.Length; k++)
        {
            letters[s[k] - 'a']++;
        }

        var count = 0;
        int i = letters.Length - 1;
        int j = letters.Length - 2;
        while (j >= 0 && letters[j] == 0)
            j--;
        while (i >= 0)
        {
            if (letters[i] == 0)
            {
                i = j;
                j--;
                count = 0;
                while (j >= 0 && letters[j] == 0)
                    j--;
                continue;
            }

            if (count >= repeatLimit)
            {
                if (j < 0)
                    break;
                sb.Append((char)(j + 'a'));
                letters[j]--;
                while (j >= 0 && letters[j] == 0)
                    j--;
                count = 0;
            }

            sb.Append((char)(i + 'a'));
            letters[i]--;
            count++;
        }

        return sb.ToString();
    }
}
