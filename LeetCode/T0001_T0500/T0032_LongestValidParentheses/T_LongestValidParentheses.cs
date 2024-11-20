namespace LeetCode.T0001_T0500.T0032_LongestValidParentheses;

public class T_LongestValidParentheses
{
    public int LongestValidParentheses(string s)
    {
        int maxLength = Math.Max(
            GetMaxLength(s.AsEnumerable(), '('),
            GetMaxLength(s.Reverse(), ')')
            );

        return maxLength;
    }

    private int GetMaxLength(IEnumerable<char> chars, char startSymbol)
    {
        int maxLength = 0;
        int countOpen = 0;
        int countClose = 0;

        foreach (char c in chars)
        {
            if (c == startSymbol)
                countOpen++;
            else
                countClose++;

            if (countOpen == countClose)
            {
                if (countOpen + countClose > maxLength)
                    maxLength = countOpen + countClose;
                continue;
            }
            if (countClose > countOpen)
            {
                countOpen = 0;
                countClose = 0;
            }
        }

        return maxLength;
    }
}
