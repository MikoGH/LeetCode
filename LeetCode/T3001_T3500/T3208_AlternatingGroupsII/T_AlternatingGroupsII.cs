namespace LeetCode.T3001_T3500.T3208_AlternatingGroupsII;

public class T_AlternatingGroupsII
{
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        var n = colors.Length;

        var i = 0;
        var j = 0;
        var count = 0;

        while (i < colors.Length)
        {
            while (j - i + 1 < k && i < colors.Length)
            {
                j++;
                if (colors[j % n] == colors[(j - 1) % n])
                    i = j;
            }
            if (i >= colors.Length)
                break;
            count++;
            i++;
        }

        return count;
    }
}
