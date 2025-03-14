namespace LeetCode.T2001_T2500.T2101_T2200.T2116_CheckIfAParenthesesStringCanBeValid;

public class T_CheckIfAParenthesesStringCanBeValid
{
    public bool CanBeValid(string s, string locked)
    {
        if (s.Length % 2 == 1)
            return false;

        var count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (locked[i] == '1' && s[i] == ')')
                count--;
            else
                count++;

            if (count < 0)
                return false;
        }

        count = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (locked[i] == '1' && s[i] == '(')
                count--;
            else
                count++;

            if (count < 0)
                return false;
        }

        return true;
    }
}
