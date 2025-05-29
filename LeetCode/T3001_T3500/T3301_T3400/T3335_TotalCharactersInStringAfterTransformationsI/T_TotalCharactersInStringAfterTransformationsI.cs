namespace LeetCode.T3001_T3500.T3301_T3400.T3335_TotalCharactersInStringAfterTransformationsI;

public class T_TotalCharactersInStringAfterTransformationsI
{
    const int _mod = (int)1e9 + 7;

    public int LengthAfterTransformations(string s, int t)
    {
        var counts = new int[26];

        for (int i = 0; i < s.Length; i++)
            counts[s[i] - 'a']++;

        for (int i = 0; i < t; i++)
        {
            var saved = counts[^1];

            for (int j = counts.Length - 1; j > 0; j--)
            {
                counts[j] = counts[j - 1];
            }
            counts[0] = saved;
            counts[1] = (counts[1] + saved) % _mod;
        }

        var sum = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            sum = (sum + counts[i]) % _mod;
        }

        return sum;
    }
}
