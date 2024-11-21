using LeetCode.T2001_T2500.T2257_CountUnguardedCellsInTheGrid;

namespace LeetCode.Tests.T2001_T2500;

public class T2257_CountUnguardedCellsInTheGrid_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_CountUnguardedCellsInTheGrid_2();

        int m = 4;
        int n = 6;
        var guards = new int[3][] {
            new int[] { 0, 0 },
            new int[] { 1, 1 },
            new int[] { 2, 3 }
        };
        var walls = new int[3][] {
            new int[] { 0, 1 },
            new int[] { 2, 2 },
            new int[] { 1, 4 }
        };

        var result = taskClass.CountUnguarded(m, n, guards, walls);

        var expected = 7;

        Assert.Equal(expected, result);
    }
}
