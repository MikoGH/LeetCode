namespace LeetCode.T3001_T3500.T3201_T3300.T3223_MinimumLengthOfStringAfterOperations;

public class T_MinimumLengthOfStringAfterOperations
{
    public int MinimumLength(string s)
    {
        var letters = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            letters[s[i] - 'a']++;
        }

        var result = 0;
        for (var i = 0; i < letters.Length; i++)
        {
            if (letters[i] > 0)
                result += (letters[i] + 1) % 2 + 1;
        }

        return result;
    }
}
