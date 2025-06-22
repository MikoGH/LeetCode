namespace LeetCode.T2001_T2500.T2101_T2200.T2138_DivideAStringIntoGroupsOfSizeK;

public class T_DivideAStringIntoGroupsOfSizeK
{
    public string[] DivideString(string s, int k, char fill)
    {
        var groupsCount = (s.Length + k - 1) / k;
        var result = new string[groupsCount];

        for (int i = 0; i < groupsCount - 1; i++)
        {
            result[i] = s.Substring(i * k, k);
        }

        result[^1] = s.Substring((groupsCount - 1) * k).PadRight(k, fill);

        return result;
    }
}
