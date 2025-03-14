namespace LeetCode.T1001_T1500.T1401_T1500.T1415_TheKthLexicographicalStringOfAllHappyStringsOfLengthn;

public class T_TheKthLexicographicalStringOfAllHappyStringsOfLengthn
{
    private int _totalCount = 0;

    public string GetHappyString(int n, int k)
    {
        var letters = new char[n];

        var f = GetHappyString(0, k, letters);

        if (!f)
            return "";

        return new string(letters);
    }

    private bool GetHappyString(int pos, int k, char[] letters)
    {
        if (pos >= letters.Length)
        {
            _totalCount++;
            return true;
        }

        for (int i = 0; i < 3; i++)
        {
            if (pos > 0 && letters[pos - 1] - 'a' == i)
                continue;
            letters[pos] = (char)('a' + i);
            GetHappyString(pos + 1, k, letters);
            if (_totalCount == k)
                return true;
        }

        return false;
    }
}
