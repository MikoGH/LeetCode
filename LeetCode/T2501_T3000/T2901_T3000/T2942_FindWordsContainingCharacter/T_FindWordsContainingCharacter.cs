namespace LeetCode.T2501_T3000.T2901_T3000.T2942_FindWordsContainingCharacter;

public class T_FindWordsContainingCharacter
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var result = new List<int>();
        for (int i = 0; i < words.Length; i++)
            if (words[i].Contains(x))
                result.Add(i);

        return result;
    }
}
