namespace LeetCode.T2501_T3000.T2559_CountVowelStringsInRanges;

public class T_CountVowelStringsInRanges
{
    public int[] VowelStrings(string[] words, int[][] queries)
    {
        var vowels = new HashSet<char>() { 'a', 'e', 'u', 'i', 'o' };
        var counts = new int[words.Length + 1];

        for (int i = 0; i < words.Length; i++)
        {
            counts[i + 1] = counts[i];
            if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][^1]))
                counts[i + 1]++;
        }

        var result = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = counts[queries[i][1] + 1] - counts[queries[i][0]];
        }

        return result;
    }
}
