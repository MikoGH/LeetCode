namespace LeetCode.T0001_T0500.T0003_LongestSubstringWithoutRepeatingCharacter;

public class T_LongestSubstringWithoutRepeatingCharacter
{
    public int LengthOfLongestSubstring(string s)
    {
        bool[] chars = Enumerable.Repeat(false, 95).ToArray();

        ushort maxCount = 0;

        int startSubstring = 0;
        int endSubstring = 0;

        while (endSubstring < s.Length)
        {
            if (chars[s[endSubstring] - 32])
            {
                chars[s[startSubstring++] - 32] = false;
                continue;
            }
            chars[s[endSubstring++] - 32] = true;
            if (endSubstring - startSubstring > maxCount)
                maxCount = (ushort)(endSubstring - startSubstring);
        }

        return maxCount;
    }
}
