using LeetCode.T2501_T3000.T2501_T2600.T2516_TakeKOfEachCharacterFromLeftAndRight;

namespace LeetCode.Tests.T2501_T3000;

public class T2516_TakeKOfEachCharacterFromLeftAndRight_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_TakeKOfEachCharacterFromLeftAndRight();

        var s = "aabaaaacaabc";
        var k = 2;

        var result = taskClass.TakeCharacters(s, k);

        var expected = 8;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_TakeKOfEachCharacterFromLeftAndRight();

        var s = "a";
        var k = 1;

        var result = taskClass.TakeCharacters(s, k);

        var expected = -1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_TakeKOfEachCharacterFromLeftAndRight();

        var s = "cbaabccac";
        var k = 3;

        var result = taskClass.TakeCharacters(s, k);

        var expected = -1;

        Assert.Equal(expected, result);
    }
}
