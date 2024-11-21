using LeetCode.T0001_T0500.T0085_MaximalRectangle;

namespace LeetCode.Tests.T0001_T0500;

public class T0085_MaximalRectangle_Tests
{
    [Fact]
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

    [Fact]
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

    [Fact]
    public void Test03()
    {
        var taskClass = new T_MaximalRectangle();

        var matrix = new char[7][]
        {
            new char[] { '0', '0', '1', '0' },
            new char[] { '0', '0', '1', '0' },
            new char[] { '0', '0', '1', '0' },
            new char[] { '0', '0', '1', '1' },
            new char[] { '0', '1', '1', '1' },
            new char[] { '0', '1', '1', '1' },
            new char[] { '1', '1', '1', '1' }
        };

        var result = taskClass.MaximalRectangle(matrix);

        var expected = 9;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_MaximalRectangle();

        var matrix = new char[7][]
        {
            new char[] { '0', '0', '0', '0' },
            new char[] { '0', '0', '0', '0' },
            new char[] { '0', '0', '0', '0' },
            new char[] { '0', '1', '0', '1' },
            new char[] { '0', '1', '1', '1' },
            new char[] { '0', '1', '1', '1' },
            new char[] { '1', '1', '1', '1' }
        };

        var result = taskClass.MaximalRectangle(matrix);

        var expected = 9;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test05()
    {
        var taskClass = new T_MaximalRectangle();

        var matrix = new char[7][]
        {
            new char[] { '0', '0', '0', '1' },
            new char[] { '0', '0', '0', '1' },
            new char[] { '0', '0', '0', '1' },
            new char[] { '0', '1', '0', '1' },
            new char[] { '0', '1', '0', '1' },
            new char[] { '0', '1', '0', '1' },
            new char[] { '1', '1', '1', '1' }
        };

        var result = taskClass.MaximalRectangle(matrix);

        var expected = 7;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test06()
    {
        var taskClass = new T_MaximalRectangle();

        var matrix = new char[5][]
        {
            new char[] { '0', '1', '1', '0', '1' },
            new char[] { '1', '1', '0', '1', '0' },
            new char[] { '0', '1', '1', '1', '0' },
            new char[] { '1', '1', '1', '1', '0' },
            new char[] { '1', '1', '1', '1', '1' }
        };

        var result = taskClass.MaximalRectangle(matrix);

        var expected = 9;

        Assert.Equal(expected, result);
    }
}
