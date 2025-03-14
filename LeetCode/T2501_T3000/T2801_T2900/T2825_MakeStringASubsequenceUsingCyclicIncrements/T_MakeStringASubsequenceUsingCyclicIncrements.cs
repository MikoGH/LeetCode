namespace LeetCode.T2501_T3000.T2801_T2900.T2825_MakeStringASubsequenceUsingCyclicIncrements;

public class T_MakeStringASubsequenceUsingCyclicIncrements
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int j = 0;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] + 1 == str2[j] || str1[i] == 'z' && str2[j] == 'a' || str1[i] == str2[j])
                j++;
            if (j == str2.Length)
                return true;
        }

        return false;
    }
}
