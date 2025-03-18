namespace LeetCode.T2501_T3000.T2501_T2600.T2594_MinimumTimeToRepairCars;

public class T_MinimumTimeToRepairCars
{
    public long RepairCars(int[] ranks, int cars)
    {
        long l = -1;
        long r = long.MaxValue;
        while (l + 1 < r)
        {
            long s = (l + r) >> 1;
            if (!Check(ranks, cars, s))
                l = s;
            else
                r = s;
        }

        return r;
    }

    private bool Check(int[] ranks, int cars, long time)
    {
        for (int i = 0; i < ranks.Length; i++)
        {
            cars -= (int)Math.Sqrt(time / ranks[i]);
            if (cars <= 0)
                return true;
        }

        return false;
    }
}
