namespace LeetCode.T1001_T1500.T1301_T1400.T1400_ConstructKPalindromeStrings;

public class T_ConstructKPalindromeStrings
{
    public bool CanConstruct(string s, int k)
    {
        var counts = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i] - 'a']++;
        }

        var minK = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] % 2 == 1)
                minK++;
        }

        if (minK <= k && s.Length >= k)
            return true;

        return false;
    }
}
