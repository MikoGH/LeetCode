using LeetCode.T0501_T1000.T0901_T1000.T0909_SnakesAndLadders;

namespace LeetCode.Tests.T0501_T1000;

public class T0909_SnakesAndLadders_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_SnakesAndLadders();

        var board = new int[6][]
        {
            new int[] {-1, -1, -1, -1, -1, -1},
            new int[] {-1, -1, -1, -1, -1, -1},
            new int[] {-1, -1, -1, -1, -1, -1},
            new int[] {-1, 35, -1, -1, 13, -1},
            new int[] {-1, -1, -1, -1, -1, -1},
            new int[] {-1, 15, -1, -1, -1, -1}
        };

        var result = taskClass.SnakesAndLadders(board);

        var expected = 4;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_SnakesAndLadders();

        var board = new int[4][]
        {
            new int[] {-1,1,2,-1},
            new int[] {2,13,15,-1},
            new int[] {-1,10,-1,-1},
            new int[] { -1, 6, 2, 8 }
        };

        var result = taskClass.SnakesAndLadders(board);

        var expected = 2;

        Assert.Equal(expected, result);
    }
}
