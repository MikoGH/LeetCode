namespace LeetCode.T2501_T3000.T2698_FindThePunishmentNumberOfAnInteger;

public class T_FindThePunishmentNumberOfAnInteger
{
    public int PunishmentNumber(int n)
    {
        var result = 0;
        for (var i = 1; i <= n; i++)
        {
            if (HasEqualSum(i, (i * i).ToString(), 0, 0, 1))
                result += i * i;
        }

        return result;
    }

    private bool HasEqualSum(int num, string s, int sum, int start, int length)
    {
        if (start + length > s.Length)
            return sum == num && length == 1;
        var result = false;

        result |= HasEqualSum(num, s, sum + int.Parse(s.Substring(start, length)), start + length, 1);
        if (result)
            return result;

        result |= HasEqualSum(num, s, sum, start, length + 1);

        return result;
    }
}
