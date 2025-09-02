namespace LeetCode.T2501_T3000.T2501_T2600.T2561_RearrangingFruits;

public class T_RearrangingFruits
{
    public long MinCost(int[] basket1, int[] basket2)
    {
        var costsDiff = new Dictionary<int, int>();
        var min = int.MaxValue;

        foreach (var cost in basket1)
        {
            costsDiff.TryAdd(cost, 0);
            costsDiff[cost]++;
            if (cost < min)
                min = cost;
        }

        foreach (var cost in basket2)
        {
            costsDiff.TryAdd(cost, 0);
            costsDiff[cost]--;
            if (cost < min)
                min = cost;
        }

        var right1 = costsDiff.Count - 1;
        var right2 = costsDiff.Count - 1;

        var sortedKeys = costsDiff.Keys.Order().ToArray();

        foreach (var key in sortedKeys)
        {
            if (costsDiff[key] % 2 == 1)
                return -1;
            costsDiff[key] >>= 1;
        }

        long result = 0;

        foreach (var key in sortedKeys)
        {
            while (costsDiff[key] > 0)
            {
                while (costsDiff[sortedKeys[right2]] >= 0)
                {
                    if (right2 < 0)
                        return -1;
                    right2--;
                }

                var count = Math.Min(costsDiff[key], -costsDiff[sortedKeys[right2]]);
                //result += count * key;
                result += count * Math.Min((long)min * 2, key);
                costsDiff[key] -= count;
                costsDiff[sortedKeys[right2]] += count;
            }

            while (costsDiff[key] < 0)
            {
                while (costsDiff[sortedKeys[right1]] <= 0)
                {
                    if (right1 < 0)
                        return -1;
                    right1--;
                }

                var count = Math.Min(-costsDiff[key], costsDiff[sortedKeys[right1]]);
                //result += count * key;
                result += count * Math.Min((long)min * 2, key);
                costsDiff[key] += count;
                costsDiff[sortedKeys[right1]] -= count;
            }
        }

        return result;
    }
}
