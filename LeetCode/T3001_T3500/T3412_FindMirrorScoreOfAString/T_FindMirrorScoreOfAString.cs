namespace LeetCode.T3001_T3500.T3412_FindMirrorScoreOfAString;

public class T_FindMirrorScoreOfAString
{
    public long CalculateScore(string s)
    {
        var lettersLastIndex = new Stack<int>[26];
        for (int i = 0; i < lettersLastIndex.Length; i++)
            lettersLastIndex[i] = new Stack<int>();
        long result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var mirrorLastIndex = lettersLastIndex[26 - (s[i] - 'a') - 1];
            if (mirrorLastIndex.Count == 0)
            {
                lettersLastIndex[s[i] - 'a'].Push(i);
                continue;
            }

            result += i - mirrorLastIndex.Pop();
        }

        return result;
    }
}
