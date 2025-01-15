namespace LeetCode.T0001_T0500.T0174_DungeonGame;

public class T_DungeonGame
{
    public int CalculateMinimumHP(int[][] dungeon)
    {
        var minHealths = new int[dungeon.Length][];
        var healths = new int[dungeon.Length][];

        for (int i = 0; i < dungeon.Length; i++)
        {
            minHealths[i] = new int[dungeon[i].Length];
            healths[i] = new int[dungeon[i].Length];
        }

        healths[0][0] = dungeon[0][0];
        minHealths[0][0] = healths[0][0];
        for (int j = 1; j < dungeon[0].Length; j++)
        {
            healths[0][j] = healths[0][j - 1] + dungeon[0][j];
            minHealths[0][j] = Math.Min(minHealths[0][j - 1], healths[0][j]);
        }

        for (int i = 1; i < dungeon.Length; i++)
        {
            healths[i][0] = healths[i - 1][0] + dungeon[i][0];
            minHealths[i][0] = Math.Min(minHealths[i - 1][0], healths[i][0]);
            for (int j = 1; j < dungeon[i].Length; j++)
            {
                var maxPreviousHealth = Math.Max(healths[i - 1][j], healths[i][j - 1]);
                var maxPreviousMinHealth = Math.Max(minHealths[i - 1][j], minHealths[i][j - 1]);
                healths[i][j] = maxPreviousHealth + dungeon[i][j];
                minHealths[i][j] = Math.Min(maxPreviousMinHealth, healths[i][j]);

                //if (minHealths[i - 1][j] > minHealths[i][j - 1])
                //{
                //    healths[i][j] = healths[i - 1][j] + dungeon[i][j];
                //    minHealths[i][j] = Math.Min(minHealths[i - 1][j], healths[i][j]);
                //}
                //else if (minHealths[i - 1][j] < minHealths[i][j - 1])
                //{
                //    healths[i][j] = healths[i][j - 1] + dungeon[i][j];
                //    minHealths[i][j] = Math.Min(minHealths[i][j - 1], healths[i][j]);
                //}
                //else
                //{
                //    var maxPreviousHealth = Math.Max(healths[i - 1][j], healths[i][j - 1]);
                //    healths[i][j] = maxPreviousHealth + dungeon[i][j];
                //    minHealths[i][j] = Math.Min(minHealths[i - 1][j], healths[i][j]);
                //}
            }
        }

        if (minHealths[^1][^1] >= 0)
            return 1;

        return -minHealths[^1][^1] + 1;
    }
}
