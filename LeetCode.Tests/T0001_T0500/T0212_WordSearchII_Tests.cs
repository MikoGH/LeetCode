using LeetCode.T0001_T0500.T0212_WordSearchII;

namespace LeetCode.Tests.T0001_T0500;

public class T0212_WordSearchII_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_WordSearchII();

        var board = new char[4][]
        {
            new char[] { 'o', 'a', 'a', 'n' },
            new char[] { 'e', 't', 'a', 'e' },
            new char[] { 'i', 'h', 'k', 'r' },
            new char[] { 'i', 'f', 'l', 'v' }
        };

        var words = new string[] { "oath", "pea", "eat", "rain" };

        var result = taskClass.FindWords(board, words);

        var expected = new string[] { "oath", "eat" };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_WordSearchII();

        var board = new char[1][]
        {
            new char[] { 'a' }
        };

        var words = new string[] { "a" };

        var result = taskClass.FindWords(board, words);

        var expected = new string[] { "a" };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_WordSearchII();

        var board = new char[4][]
        {
            new char[] { 'o', 'a', 'b', 'n' },
            new char[] { 'o', 't', 'a', 'e' },
            new char[] { 'a', 'h', 'k', 'r' },
            new char[] { 'a', 'f', 'l', 'v' }
        };

        var words = new string[] { "oa", "oaa" };

        var result = taskClass.FindWords(board, words);

        var expected = new string[] { "oa", "oaa" };

        Assert.Equal(expected, result);
    }
}
