namespace LeetCode.T2001_T2500.T2301_T2400.T2337_MovePiecesToObtainAString;

public class T_MovePiecesToObtainAString
{
    public bool CanChange(string start, string target)
    {
        int i = 0;
        int countL = 0, countR = 0;
        while (i < start.Length)
        {
            if (start[i] == 'R')
            {
                if (countL > 0)
                    return false;
                countR++;
            }
            if (target[i] == 'L')
            {
                if (countR > 0)
                    return false;
                countL++;
            }
            if (target[i] == 'R')
            {
                if (countR == 0)
                    return false;
                countR--;
            }
            if (start[i] == 'L')
            {
                if (countL == 0)
                    return false;
                countL--;
            }

            i++;
        }

        if (countR > 0 || countL > 0)
            return false;

        return true;
    }
}
