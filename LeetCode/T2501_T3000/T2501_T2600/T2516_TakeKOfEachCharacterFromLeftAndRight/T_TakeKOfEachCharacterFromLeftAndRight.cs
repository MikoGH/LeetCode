namespace LeetCode.T2501_T3000.T2501_T2600.T2516_TakeKOfEachCharacterFromLeftAndRight;

public class T_TakeKOfEachCharacterFromLeftAndRight
{
    public int TakeCharacters(string s, int k)
    {
        var length = s.Length;
        var dpAscended = new int[length + 1, 3];
        var dpDescended = new int[length + 1, 3];

        for (int j = 0; j < 3; j++)
        {
            dpAscended[0, j] = 0;
            dpDescended[0, j] = 0;
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                dpAscended[i + 1, j] = dpAscended[i, j];
                dpDescended[i + 1, j] = dpDescended[i, j];
            }
            dpAscended[i + 1, s[i] - 'a']++;
            dpDescended[i + 1, s[length - 1 - i] - 'a']++;
        }

        if (!Check(dpAscended, dpDescended, length, 0, k))
            return -1;

        var ascendedPos = length;
        var descendedPos = 0;
        var minLength = length + 1;

        while (descendedPos <= length)
        {
            if (Check(dpAscended, dpDescended, ascendedPos, descendedPos, k))
            {
                if (ascendedPos + descendedPos < minLength)
                    minLength = ascendedPos + descendedPos;
                if (ascendedPos == 0)
                    break;
                if (ascendedPos > 0)
                    ascendedPos--;
                continue;
            }
            descendedPos++;
        }

        return minLength;
    }

    private static bool Check(int[,] dpAscended, int[,] dpDescended, int ascendedPos, int descendedPos, int k)
    {
        return dpAscended[ascendedPos, 0] + dpDescended[descendedPos, 0] >= k
            && dpAscended[ascendedPos, 1] + dpDescended[descendedPos, 1] >= k
            && dpAscended[ascendedPos, 2] + dpDescended[descendedPos, 2] >= k;
    }
}
