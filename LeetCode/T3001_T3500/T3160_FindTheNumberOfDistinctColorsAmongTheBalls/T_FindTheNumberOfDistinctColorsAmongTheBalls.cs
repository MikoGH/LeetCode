namespace LeetCode.T3001_T3500.T3160_FindTheNumberOfDistinctColorsAmongTheBalls;

public class T_FindTheNumberOfDistinctColorsAmongTheBalls
{
    public int[] QueryResults(int limit, int[][] queries)
    {
        var balls = new Dictionary<int, int>();
        var colors = new Dictionary<int, int>();

        var result = new int[queries.Length];
        var distinct = 0;

        for (int i = 0; i < queries.Length; i++)
        {
            if (balls.ContainsKey(queries[i][0]))
            {
                colors[balls[queries[i][0]]]--;

                if (colors[balls[queries[i][0]]] == 0)
                {
                    colors.Remove(balls[queries[i][0]]);
                    distinct--;
                }
            }

            if (!balls.ContainsKey(queries[i][0]))
                balls.Add(queries[i][0], queries[i][1]);
            else
                balls[queries[i][0]] = queries[i][1];

            if (!colors.ContainsKey(queries[i][1]))
                colors.Add(queries[i][1], 1);
            else
                colors[queries[i][1]]++;

            if (colors[queries[i][1]] == 1)
                distinct++;

            result[i] = distinct;
        }

        return result;
    }
}
