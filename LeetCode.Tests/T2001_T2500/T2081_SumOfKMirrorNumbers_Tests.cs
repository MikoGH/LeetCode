using LeetCode.T2001_T2500.T2001_T2100.T2081_SumOfKMirrorNumbers;

namespace LeetCode.Tests.T2001_T2500;

public class T2081_SumOfKMirrorNumbers_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_SumOfKMirrorNumbers();

        var k = 2;

        int n = 5;

        var result = taskClass.KMirror(k, n);

        var expected = 25;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_SumOfKMirrorNumbers();

        var k = 3;

        int n = 7;

        var result = taskClass.KMirror(k, n);

        var expected = 499;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_SumOfKMirrorNumbers();

        var k = 8;

        int n = 15;

        var result = taskClass.KMirror(k, n);

        var expected = 5818;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_SumOfKMirrorNumbers();

        var k = 9;

        int n = 30;

        var result = taskClass.KMirror(k, n);

        var expected = 18627530;

        Assert.Equal(expected, result);
    }
}
