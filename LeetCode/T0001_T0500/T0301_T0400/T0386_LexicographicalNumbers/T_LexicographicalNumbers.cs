namespace LeetCode.T0001_T0500.T0301_T0400.T0386_LexicographicalNumbers;

public class T_LexicographicalNumbers
{
    public IList<int> LexicalOrder(int n)
    {
        var result = new List<int>();

        Dfs(result, 0, n);

        return result;
    }

    private void Dfs(List<int> result, int number, int max)
    {
        number *= 10;

        for (int i = 0; i < 10; i++)
        {
            if (number + i > max)
                return;

            if (number + i == 0)
                continue;

            result.Add(number + i);

            Dfs(result, number + i, max);
        }
    }
}
