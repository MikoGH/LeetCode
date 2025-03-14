namespace LeetCode.T2001_T2500.T2301_T2400.T2381_ShiftingLettersII;

public class T_ShiftingLettersII
{
    public string ShiftingLetters(string s, int[][] shifts)
    {
        var shiftCounts = new int[s.Length + 1];

        for (int i = 0; i < shifts.Length; i++)
        {
            if (shifts[i][2] == 0)
            {
                shiftCounts[shifts[i][0]]--;
                shiftCounts[shifts[i][1] + 1]++;
            }
            else
            {
                shiftCounts[shifts[i][0]]++;
                shiftCounts[shifts[i][1] + 1]--;
            }
        }

        var shift = 0;
        var chars = s.ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            shift += shiftCounts[i];
            var charNum = (chars[i] - 'a' + shift) % 26;
            if (charNum < 0)
                charNum = 'z' - 'a' + 1 + charNum;
            chars[i] = (char)(charNum + 'a');
        }

        return new string(chars);
    }
}
