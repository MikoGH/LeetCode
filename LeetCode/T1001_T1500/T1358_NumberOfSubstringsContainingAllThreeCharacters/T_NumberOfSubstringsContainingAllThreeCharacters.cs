namespace LeetCode.T1001_T1500.T1358_NumberOfSubstringsContainingAllThreeCharacters;

public class T_NumberOfSubstringsContainingAllThreeCharacters
{
    public int NumberOfSubstrings(string s)
    {
        var result = 0;
        var lastA = -1;
        var lastB = -1;
        var lastC = -1;

        var i = 0;

        while (i < s.Length)
        {
            switch (s[i])
            {
                case 'a':
                    lastA = i;
                    break;
                case 'b':
                    lastB = i;
                    break;
                case 'c':
                    lastC = i;
                    break;
            }
            result += Math.Min(Math.Min(lastA, lastB), lastC) + 1;
            i++;
        }

        return result;
    }
}
