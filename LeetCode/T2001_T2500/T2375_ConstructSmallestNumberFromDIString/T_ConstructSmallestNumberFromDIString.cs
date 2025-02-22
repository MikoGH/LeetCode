namespace LeetCode.T2001_T2500.T2375_ConstructSmallestNumberFromDIString;

public class T_ConstructSmallestNumberFromDIString
{
    public string SmallestNumber(string pattern)
    {
        var used = new bool[10];
        var result = new char[pattern.Length + 1];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = '0';
        }

        GetSmallestNumber(pattern, used, result, 0);

        return new string(result);
    }

    private bool GetSmallestNumber(string pattern, bool[] used, char[] result, int pos)
    {
        if (pos >= result.Length)
            return true;

        for (int i = 1; i <= 9; i++)
        {
            result[pos] = i.ToString()[0];

            if (used[i])
                continue;

            if (pos > 0 && (pattern[pos - 1] == 'I' && result[pos - 1] > result[pos] || pattern[pos - 1] == 'D' && result[pos - 1] < result[pos]))
                continue;

            used[i] = true;
            var f = GetSmallestNumber(pattern, used, result, pos + 1);
            used[i] = false;

            if (f)
                return true;
        }

        return false;
    }
}
