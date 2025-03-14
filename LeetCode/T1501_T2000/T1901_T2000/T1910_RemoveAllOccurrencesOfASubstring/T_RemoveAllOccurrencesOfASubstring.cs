namespace LeetCode.T1501_T2000.T1901_T2000.T1910_RemoveAllOccurrencesOfASubstring;

public class T_RemoveAllOccurrencesOfASubstring
{
    public string RemoveOccurrences(string s, string part)
    {
        var lps = GetLongestPrefixSum(part);

        var charStack = new Stack<char>();
        var patternIndexes = new int[s.Length + 1];

        var patternIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            charStack.Push(s[i]);
            if (s[i] == part[patternIndex])
            {
                patternIndexes[charStack.Count] = ++patternIndex;
                if (patternIndex == part.Length)
                {
                    for (int j = 0; j < part.Length; j++)
                        charStack.Pop();

                    patternIndex = charStack.Count == 0
                        ? 0
                        : patternIndexes[charStack.Count];
                }
            }
            else
            {
                if (patternIndex != 0)
                {
                    patternIndex = lps[patternIndex - 1];
                    i--;
                    charStack.Pop();
                }
                else
                {
                    patternIndexes[charStack.Count] = 0;
                }
            }
        }

        return new string(charStack.Reverse().ToArray());
    }

    private int[] GetLongestPrefixSum(string part)
    {
        var lps = new int[part.Length];

        for (int i = 1; i < part.Length; i++)
        {
            if (part[i] == part[lps[i - 1] + 1])
                lps[i] = lps[i - 1] + 1;
        }

        return lps;
    }
}
