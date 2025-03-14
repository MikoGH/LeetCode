namespace LeetCode.T1501_T2000.T1701_T1800.T1790_CheckIfOneStringSwapCanMakeStringsEqual;

public class T_CheckIfOneStringSwapCanMakeStringsEqual
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        var letters = new int[26];
        var sameCount = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            letters[s1[i] - 'a']++;
            letters[s2[i] - 'a']--;

            if (s1[i] == s2[i])
                sameCount++;
        }

        if (sameCount != s1.Length && sameCount != s1.Length - 2)
            return false;

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] != 0)
                return false;
        }

        return true;
    }
}
