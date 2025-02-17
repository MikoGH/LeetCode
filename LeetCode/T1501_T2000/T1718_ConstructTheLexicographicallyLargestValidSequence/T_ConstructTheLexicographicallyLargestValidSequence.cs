namespace LeetCode.T1501_T2000.T1718_ConstructTheLexicographicallyLargestValidSequence;

public class T_ConstructTheLexicographicallyLargestValidSequence
{
    public int[] ConstructDistancedSequence(int n)
    {
        var result = new int[n * 2 - 1];
        var used = new bool[n + 1];

        Next(used, result, 0);

        return result;
    }

    private bool Next(bool[] used, int[] result, int pos)
    {
        var completed = false;

        if (pos >= result.Length)
            return true;

        if (result[pos] != 0)
            return Next(used, result, pos + 1);

        for (int i = used.Length - 1; i > 1; i--)
        {
            if (used[i] || pos + i >= result.Length || result[pos + i] != 0)
                continue;

            used[i] = true;
            result[pos] = i;
            result[pos + i] = i;
            completed = Next(used, result, pos + 1);
            if (completed)
                return true;
            used[i] = false;
            result[pos] = 0;
            result[pos + i] = 0;
        }

        if (used[1])
            return false;

        used[1] = true;
        result[pos] = 1;
        completed = Next(used, result, pos + 1);
        if (completed)
            return true;
        used[1] = false;
        result[pos] = 0;

        return false;
    }
}
