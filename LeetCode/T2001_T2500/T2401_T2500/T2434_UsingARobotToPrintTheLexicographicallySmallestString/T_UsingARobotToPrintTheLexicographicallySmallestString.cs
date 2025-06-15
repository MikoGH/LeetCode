namespace LeetCode.T2001_T2500.T2401_T2500.T2434_UsingARobotToPrintTheLexicographicallySmallestString;

public class T_UsingARobotToPrintTheLexicographicallySmallestString
{
    public string RobotWithString(string s)
    {
        var result = new char[s.Length];
        var resultPos = 0;

        var t = new Stack<int>();

        var countsS = new int[26];
        foreach (var smb in s)
            countsS[smb - 'a']++;

        var sPos = 0;
        for (int countsPos = 0; countsPos < countsS.Length; countsPos++)
        {
            while (t.TryPeek(out var peek) && peek <= countsPos)
            {
                var smb = t.Pop();
                result[resultPos++] = (char)(smb + 'a');
            }

            while (countsS[countsPos] > 0)
            {
                var smb = s[sPos] - 'a';

                if (smb == countsPos)
                {
                    countsS[smb]--;
                    result[resultPos++] = s[sPos];
                }
                else
                {
                    countsS[smb]--;
                    t.Push(smb);
                }

                sPos++;
            }
        }

        return new string(result);
    }
}
