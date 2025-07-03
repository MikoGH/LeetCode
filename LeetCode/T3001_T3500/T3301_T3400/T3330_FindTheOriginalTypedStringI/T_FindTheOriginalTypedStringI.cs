namespace LeetCode.T3001_T3500.T3301_T3400.T3330_FindTheOriginalTypedStringI;

public class T_FindTheOriginalTypedStringI
{
    public int PossibleStringCount(string word)
    {
        var count = 1;

        var copy = word;
        var len = copy.Length;

        for (int i = 1; i < len; i++)
        {
            if (copy[i] == copy[i - 1])
                count++;
        }

        return count;
    }
}
