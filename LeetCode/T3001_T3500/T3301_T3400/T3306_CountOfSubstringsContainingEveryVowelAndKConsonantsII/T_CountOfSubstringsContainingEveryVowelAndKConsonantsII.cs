namespace LeetCode.T3001_T3500.T3301_T3400.T3306_CountOfSubstringsContainingEveryVowelAndKConsonantsII;

public class T_CountOfSubstringsContainingEveryVowelAndKConsonantsII
{
    public long CountOfSubstrings(string word, int k)
    {
        return Count(word, k) - Count(word, k + 1);
    }

    private long Count(string word, int k)
    {
        long result = 0;

        var countUniqueVovels = 0;
        var countConsonants = 0;

        var dct = new Dictionary<char, int>();
        dct.Add('a', 0);
        dct.Add('o', 0);
        dct.Add('u', 0);
        dct.Add('e', 0);
        dct.Add('i', 0);

        var i = 0;
        var j = 0;
        while (j < word.Length)
        {
            if (dct.ContainsKey(word[j]))
            {
                if (dct[word[j]] == 0)
                    countUniqueVovels++;
                dct[word[j]]++;
            }
            else
                countConsonants++;

            while (countUniqueVovels == 5 && countConsonants >= k)
            {
                result += word.Length - j;

                if (dct.ContainsKey(word[i]))
                {
                    if (dct[word[i]] == 1)
                        countUniqueVovels--;
                    dct[word[i]]--;
                }
                else
                {
                    countConsonants--;
                }
                i++;
            }

            j++;
        }

        return result;
    }
}
