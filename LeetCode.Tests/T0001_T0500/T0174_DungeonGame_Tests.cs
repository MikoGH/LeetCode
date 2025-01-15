using LeetCode.T0001_T0500.T0174_DungeonGame;

namespace LeetCode.Tests.T0001_T0500;

public class T0174_DungeonGame_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_DungeonGame();

        var dungeons = new int[3][] {
            new int[] { 1, -3, 3 },
            new int[] { 0, -2, 0 },
            new int[] { -3, -3, -3 }
        };

        var result = taskClass.CalculateMinimumHP(dungeons);

        var expected = 3;

        Assert.Equal(expected, result);
    }
}
