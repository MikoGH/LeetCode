using LeetCode.T0501_T1000.T0796_RotateString;

namespace LeetCode.Tests.T0501_T1000;

public class T0796_RotateString_Tests
{
    [Fact]
    public void Test1()
    {
        var taskClass = new T_RotateString();
        string s = "abcde";
        string goal = "eabcd";
        var result = taskClass.RotateString(s, goal);
        Assert.True(result);
    }
}
