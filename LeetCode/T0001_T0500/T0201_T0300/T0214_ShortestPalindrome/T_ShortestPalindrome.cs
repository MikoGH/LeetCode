namespace LeetCode.T0001_T0500.T0201_T0300.T0214_ShortestPalindrome;

public class T_ShortestPalindrome
{
    private const ulong _k = 37;
    private List<ulong> _kPows;
    private const ulong _mod = ulong.MaxValue;

    public string ShortestPalindrome(string s)
    {
        var sReversed = string.Join("", s.Reverse());

        // Получить степени k
        _kPows = GetKPows(s.Length);

        // Получить обратные полиномиальные хэши строк для всех вариантов с начала строки
        var sHashResults = GetHashResults(s);
        var sReversedHashResults = GetHashResults(sReversed);
        var n = s.Length;

        for (int i = n / 2; i >= 0; i--)
        {
            if (n - 2 * i - 1 >= 0 && sHashResults[i] == GetHashSlice(sReversedHashResults, n - 2 * i - 1, n - i - 1))
                return string.Concat(sReversed.Substring(0, n - 2 * i - 1), s);
            if (sHashResults[i] == GetHashSlice(sReversedHashResults, n - 2 * i, n - i))
                return string.Concat(sReversed.Substring(0, n - 2 * i), s);
        }

        return s;
    }

    // Получить степени k
    private List<ulong> GetKPows(int n)
    {
        var kPows = new List<ulong>(n + 1);
        kPows.Add(1);
        for (var i = 1; i < n + 1; i++)
        {
            kPows.Add(kPows[i - 1] * _k % _mod);
        }
        return kPows;
    }

    // Получить обратные полиномиальные хэши строк для всех вариантов с начала строки
    private List<ulong> GetHashResults(string s)
    {
        var hashResults = new List<ulong>(s.Length + 1);
        hashResults.Add(0);

        ulong hash = 0;
        for (var i = 0; i < s.Length; i++)
        {
            hash = (hash * _k + CharToNumber(s[i])) % _mod;
            hashResults.Add(hash);
        }

        return hashResults;
    }

    // Получить обратный полиномиальный хэш среза строки
    private ulong GetHashSlice(List<ulong> hashResults, int startIndex, int endIndex)
    {
        //Console.WriteLine(endIndex);
        var hashResult = (hashResults[endIndex] - hashResults[startIndex] * _kPows[endIndex - startIndex]) % _mod;
        if (hashResult < 0)
            hashResult = _mod + hashResult;
        return hashResult;
    }

    private ulong CharToNumber(char c)
        => (ulong)(c - 'a' + 1);
}


//for (var i = 0; i<sHashResults.Count; i++)
//{
//    Console.WriteLine($"{sHashResults[i] == sReversedHashResults[i]} {sHashResults[i]} {sReversedHashResults[i]} {i}");
//}

//for (var i = 2; i<sHashResults.Count; i++)
//{
//    //Console.WriteLine($"{sHashResults[i] == sReversedHashResults[i]} {sHashResults[i]} {sReversedHashResults[i]} {i}");
//    if (sHashResults[i - 2] == sReversedHashResults[i - 2] && sHashResults[i - 1] != sReversedHashResults[i - 1])
//    {
//        Console.WriteLine($"{sHashResults[i - 2] == sReversedHashResults[i - 2]} {sHashResults[i - 2]} {sReversedHashResults[i - 2]} {i - 2}");
//        Console.WriteLine($"{sHashResults[i - 1] == sReversedHashResults[i - 1]} {sHashResults[i - 1]} {sReversedHashResults[i - 1]} {i - 1}");
//        break;
//    }
//}