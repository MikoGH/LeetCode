namespace LeetCode.T2001_T2500.T2101_T2200.T2131_LongestPalindromeByConcatenatingTwoLetterWords;

public class T_LongestPalindromeByConcatenatingTwoLetterWords
{
    public int LongestPalindrome(string[] words)
    {
        var dct = new Dictionary<string, int>();

        var length = 0;

        foreach (var word in words)
        {
            var reverted = new string([word[1], word[0]]);
            if (dct.TryGetValue(reverted, out int value) && value > 0)
            {
                length += 4;
                dct[reverted] = --value;
            }
            else
            {
                if (dct.ContainsKey(word))
                    dct[word]++;
                else
                    dct.Add(word, 1);
            }
        }

        for (int i = 0; i < 26; i++)
        {
            var smb = (char)('a' + i);
            var mid = new string([smb, smb]);

            if (dct.TryGetValue(mid, out var value) && value > 0)
            {
                length += 2;
                break;
            }
        }

        return length;
    }
}
