using LeetCode.T0501_T1000.T0827_MakingALargeIsland;

namespace LeetCode.Tests.T0501_T1000;

public class T0827_MakingALargeIsland_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MakingALargeIsland();

        var grid = new int[2][] 
            { 
                new int[2] { 1, 0 },
                new int[2] { 0, 1 }
            };

        var result = taskClass.LargestIsland(grid);

        var expected = 3;

        Assert.Equal(expected, result);
    }
}
