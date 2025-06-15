namespace LeetCode.T3001_T3500.T3101_T3200.T3170_LexicographicallyMinimumStringAfterRemovingStars;

public class T_LexicographicallyMinimumStringAfterRemovingStars
{
    public string ClearStars(string s)
    {
        var queue = new PriorityQueue<int, (char Smb, int Pos)>();

        var deleted = new bool[s.Length];

        var countDeleted = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                deleted[i] = true;
                var pos = queue.Dequeue();
                deleted[pos] = true;
                countDeleted += 2;
            }
            else
                queue.Enqueue(i, (s[i], -i));
        }

        var result = new char[s.Length - countDeleted];
        var index = 0;

        for (int i = 0; i < deleted.Length; i++)
        {
            if (!deleted[i])
                result[index++] = s[i];
        }

        return new string(result);
    }
}
