namespace LeetCode.T1501_T2000.T1701_T1800.T1780_CheckIfNumberIsASumOfPowersOfThree;

public class T_CheckIfNumberIsASumOfPowersOfThree
{
    public bool CheckPowersOfThree(int n)
    {
        while (n > 0)
        {
            if (n % 3 == 2)
                return false;
            n /= 3;
        }

        return true;
    }
}
