namespace LeetCode.T1001_T1500.T1408_StringMatchingInAnArray;

public class T_StringMatchingInAnArray
{
    public IList<string> StringMatching(string[] words)
    {
        return words.Where(x => words.Any(y => y.Length > x.Length && y.Contains(x))).ToList();
    }
}
