namespace LeetCode.T3001_T3500.T3401_T3500.T3485_LongestCommonPrefixOfKStringsAfterRemoval;

public class T_LongestCommonPrefixOfKStringsAfterRemoval
{
    public int[] LongestCommonPrefix(string[] words, int k)
    {
        var dct = new Dictionary<string, int>();
        var sortedWords = words.AsEnumerable().OrderByDescending(x => x).ToArray();

        for (int i = 0; i < sortedWords.Length; i++)
        {
            var minSize = Math.Min(sortedWords[i].Length, sortedWords[i + k - 1].Length);
            int j = 0;
            while (j < minSize && sortedWords[i][j] == sortedWords[i + k - 1][j])
            {
                j++;
            }
            if (j > 0 && !dct.ContainsKey(sortedWords[i].Substring(0, j)))
                dct[sortedWords[i].Substring(0, j)] = k;

            if (i + k >= sortedWords.Length)
                break;

            minSize = Math.Min(sortedWords[i].Length, sortedWords[i + k].Length);
            j = 0;
            while (j < minSize && sortedWords[i][j] == sortedWords[i + k][j])
            {
                j++;
            }
            if (j > 0)
                dct[sortedWords[i].Substring(0, j)] = k + 1;
        }

        var maxes = dct
            .Where(x => x.Value >= k)
            .OrderByDescending(x => x.Key.Length)
            .Take(2)
            .ToList();

        var result = new int[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            if (maxes.Count == 0)
            {
                result[i] = 0;
                continue;
            }

            if (words[i].StartsWith(maxes[0].Key))
            {
                if (maxes[0].Value > k)
                    result[i] = maxes[0].Key.Length;
                else
                    if (maxes.Count > 1)
                    result[i] = maxes[1].Key.Length;
                else result[i] = 0;
            }
            else
            {
                result[i] = maxes[0].Key.Length;
            }
        }

        return result;
    }
}
