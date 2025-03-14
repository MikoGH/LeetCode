using LeetCode.T3001_T3500.T3101_T3200.T3133_MinimumArrayEnd;

namespace LeetCode.Tests.T3001_T3500;

public class T3133_MinimumArrayEnd_Tests
{
    [Theory]
    [InlineData(3, 4, 6)]
    [InlineData(2, 7, 15)]
    [InlineData(3, 1, 5)]
    [InlineData(68, 176, 691)]
    [InlineData(6715154, 7193485, 55012476815)]
    [InlineData(9670929, 26736017, 316916889041)]
    public void Test01(int n, int x, long expected)
    {
        var taskClass = new T_MinimumArrayEnd();

        var result = taskClass.MinEnd(n, x);

        Assert.Equal(expected, result);
    }
}
