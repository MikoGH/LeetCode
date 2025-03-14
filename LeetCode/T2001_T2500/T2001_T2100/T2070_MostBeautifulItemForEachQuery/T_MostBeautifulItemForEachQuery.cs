namespace LeetCode.T2001_T2500.T2001_T2100.T2070_MostBeautifulItemForEachQuery;

public class T_MostBeautifulItemForEachQuery
{
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        items = items
            .OrderBy(x => x[0])
            .ThenBy(x => -x[1])
            .ToArray();

        for (int i = 1; i < items.Length; i++)
        {
            if (items[i][1] < items[i - 1][1])
                items[i][1] = items[i - 1][1];
        }

        for (int j = 0; j < queries.Length; j++)
        {
            queries[j] = PriceBinarySearch(items, queries[j]);
        }

        return queries;
    }

    private int PriceBinarySearch(int[][] items, int query)
    {
        int l = 0, r = items.Length;

        while (l + 1 < r)
        {
            var s = (l + r) / 2;

            if (items[s][0] <= query)
                l = s;
            else
                r = s;
        }

        if (items[l][0] > query)
            return 0;

        return items[l][1];
    }
}
