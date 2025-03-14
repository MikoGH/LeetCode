using LeetCode.T1001_T1500.T1001_T1100.T1092_ShortestCommonSupersequence;

namespace LeetCode.Tests.T1001_T1500;

public class T1092_ShortestCommonSupersequence_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ShortestCommonSupersequence();

        var str1 = "abac";
        var str2 = "cab";

        var result = taskClass.ShortestCommonSupersequence(str1, str2);

        var expected = "cabac";

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_ShortestCommonSupersequence();

        var str1 = "aaaaaa";
        var str2 = "aaa";

        var result = taskClass.ShortestCommonSupersequence(str1, str2);

        var expected = "aaaaaa";

        Assert.Equal(expected, result);
    }
}
