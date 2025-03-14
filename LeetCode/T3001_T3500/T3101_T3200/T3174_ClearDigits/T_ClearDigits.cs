namespace LeetCode.T3001_T3500.T3101_T3200.T3174_ClearDigits;

public class T_ClearDigits
{
    HashSet<char> digits = Enumerable.Range(0, 10).Select(x => x.ToString()[0]).ToHashSet();
    public string ClearDigits(string s)
    {
        var lst = new List<char>(s.Length);
        for (int i = 0; i < s.Length; i++)
        {
            if (digits.Contains(s[i]))
                lst.RemoveAt(lst.Count - 1);
            else
                lst.Add(s[i]);
        }

        return new string(lst.ToArray());
    }
}
