namespace LeetCode.T2501_T3000.T2901_T3000.T2981_FindLongestSpecialSubstringThatOccursThriceI;

public class T_FindLongestSpecialSubstringThatOccursThriceI
{
    public int MaximumLength(string s)
    {
        byte[][] substringsOfCharacters = new byte[26][];

        for (int i = 0; i < substringsOfCharacters.Length; i++)
        {
            substringsOfCharacters[i] = new byte[3];
        }

        byte count = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                count++;
                continue;
            }

            AddLength(substringsOfCharacters[s[i - 1] - 'a'], s, count);
            count = 1;
        }

        AddLength(substringsOfCharacters[s[s.Length - 1] - 'a'], s, count);

        int maxLength = 0;
        for (int i = 0; i < substringsOfCharacters.Length; i++)
        {
            var maxLengthOfChar = GetMaximumLengthOfChar(substringsOfCharacters[i]);
            if (maxLengthOfChar > maxLength)
                maxLength = maxLengthOfChar;
        }

        if (maxLength == 0)
            return -1;

        return maxLength;
    }

    private void AddLength(byte[] substringsOfCharacter, string s, byte count)
    {
        var minIndex = 0;
        for (int j = 1; j < 3; j++)
            if (substringsOfCharacter[j] < substringsOfCharacter[minIndex])
                minIndex = j;
        if (substringsOfCharacter[minIndex] < count)
            substringsOfCharacter[minIndex] = count;
    }

    private int GetMaximumLengthOfChar(byte[] charLengths)
    {
        if (charLengths[0] == 0)
            return 0;

        if (charLengths[0] == charLengths[1] && charLengths[1] == charLengths[2])
            return charLengths[0];

        var maxLength = 0;
        for (int j = 0; j < 3; j++)
            if (charLengths[j] > maxLength)
                maxLength = charLengths[j];

        var count = 0;
        for (int j = 0; j < 3; j++)
            if (charLengths[j] >= maxLength - 1)
                count++;

        if (count >= 2)
            return maxLength - 1;

        if (maxLength > 2)
            return maxLength - 2;

        return 0;
    }
}
