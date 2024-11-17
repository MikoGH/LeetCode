namespace LeetCode.T0501_T1000.T0796_RotateString;

public class T_RotateString
{
    private const int _k = 10;
    private List<long> _kPows;
    private const long _mod = 3571;

    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;

        // Получить степени k
        _kPows = GetKPows(s.Length);

        // Получить обратные полиномиальные хэши строк для всех вариантов с начала строки для s и goal
        var sHashResults = GetHashResults(s);
        var goalHashResults = GetHashResults(goal);

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (sHashResults[i] == GetRightHash(goalHashResults, s.Length - i - 2)
                && GetRightHash(sHashResults, i) == goalHashResults[s.Length - i - 2])
                return true;
        }

        if (sHashResults[s.Length - 1] == goalHashResults[goal.Length - 1])
            return true;

        return false;
    }

    // Получить степени k
    private List<long> GetKPows(int n)
    {
        var kPows = new List<long>(n + 1);
        kPows.Add(1);
        for (int i = 1; i < n + 1; i++)
        {
            kPows.Add(kPows[i - 1] * _k % _mod);
        }
        return kPows;
    }

    // Получить обратные полиномиальные хэши строк для всех вариантов с начала строки для s и goal
    private List<long> GetHashResults(string s)
    {
        var hashResults = new List<long>(s.Length);

        long hash = 0;
        for (int i = 0; i < s.Length; i++)
        {
            hash = (hash * _k + CharToNumber(s[i])) % _mod;
            hashResults.Add(hash);
        }

        return hashResults;
    }

    // Получить обратный полиномиальный хэш строки с заданного индекса до правого края
    private long GetRightHash(List<long> hashResults, int start)
    {
        var hashResult = (hashResults[hashResults.Count - 1] - hashResults[start] * _kPows[hashResults.Count - 1 - start] % _mod) % _mod;
        if (hashResult < 0)
            hashResult = _mod + hashResult;
        return hashResult;
    }

    private long CharToNumber(char c)
        => c - 'a' + 1;
}
