namespace LeetCode.T3001_T3500.T3403_FindtheLexicographicallyLargestStringFromtheBoxI;

public class T_FindtheLexicographicallyLargestStringFromtheBoxI
{
    public string AnswerString(string word, int numFriends)
    {
        if (numFriends == 1)
            return word;

        char[] best = new char[word.Length - numFriends + 1];
        var bestLength = 0;

        for (int start = 0; start < word.Length; start++)
        {
            var f = false;
            var right = Math.Min(word.Length - numFriends + 1, word.Length - start);
            var length = 0;
            for (int i = 0; i < right; i++)
            {
                if (!f && word[start + i] < best[i])
                    break;
                if (word[start + i] > best[i])
                    f = true;

                length++;
                best[i] = word[start + i];
            }
            if (length > bestLength || f)
                bestLength = length;
        }

        return new string(best.Take(bestLength).ToArray());
    }
}
