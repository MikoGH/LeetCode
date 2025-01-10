namespace LeetCode.T0501_T1000.T0916_WordSubsets;

public class T_WordSubsets
{
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        var totalLetters = new int[26];
        int[] letters;
        var result = new List<string>();

        foreach (var word in words2)
        {
            letters = new int[26];
            for (int i = 0; i < word.Length; i++)
            {
                var letterIndex = word[i] - 'a';
                letters[letterIndex]++;
                if (letters[letterIndex] > totalLetters[letterIndex])
                    totalLetters[letterIndex] = letters[letterIndex];
            }
        }

        foreach (var word in words1)
        {
            letters = new int[26];
            var f = true;
            for (int i = 0; i < word.Length; i++)
            {
                var letterIndex = word[i] - 'a';
                letters[letterIndex]++;
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] < totalLetters[i])
                {
                    f = false;
                    break;
                }
            }
            if (!f) continue;
            result.Add(word);
        }

        return result;
    }
}
