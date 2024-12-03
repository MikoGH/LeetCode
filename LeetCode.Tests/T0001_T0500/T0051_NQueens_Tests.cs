using LeetCode.T0001_T0500.T0051_NQueens;

namespace LeetCode.Tests.T0001_T0500;

public class T0051_NQueens_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_NQueens();

        var n = 4;

        var result = taskClass.SolveNQueens(n);

        var expected = new string[2][] {
            new string[4] { "..Q.", "Q...", "...Q", ".Q.." },
            new string[4] { ".Q..", "...Q", "Q...", "..Q." }
        };

        Assert.Equal(expected, result);
    }
}
