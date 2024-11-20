using LeetCode.T0001_T0500.T0085_MaximalRectangle;
using LeetCode.T0501_T1000.T0862_ShortestSubarrayWithSumAtLeastK;

namespace LeetCode.Tests.T0001_T0500;

public class T0085_MaximalRectangle_Tests
{
    [Fact(Skip = "Не решено")]
    public void Test01()
    {
        var taskClass = new T_MaximalRectangle();

        var matrix = new char[4][]
        {
            new char[] { '1', '0', '1', '0', '0' },
            new char[] { '1', '0', '1', '1', '1' },
            new char[] { '1', '1', '1', '1', '1' },
            new char[] { '1', '0', '0', '1', '0' }
        };

        var result = taskClass.MaximalRectangle(matrix);

        var expected = 6;

        Assert.Equal(expected, result);
    }

    [Fact(Skip = "Не решено")]
    public void Test02()
    {
        var taskClass = new T_MaximalRectangle();

        var matrix = new char[3][]
        {
            new char[] { '0', '0', '0', '0', '0' },
            new char[] { '0', '0', '0', '0', '0' },
            new char[] { '1', '1', '1', '1', '1' }
        };

        var result = taskClass.MaximalRectangle(matrix);

        var expected = 5;

        Assert.Equal(expected, result);
    }
}
