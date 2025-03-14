using LeetCode.T2501_T3000.T2501_T2600.T2601_PrimeSubtractionOperation;

namespace LeetCode.Tests.T2501_T3000;

public class T2601_PrimeSubtractionOperation_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_PrimeSubtractionOperation();

        var nums = new int[] { 4, 9, 6, 10 };

        var result = taskClass.PrimeSubOperation(nums);

        var expected = true;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_PrimeSubtractionOperation();

        var nums = new int[] { 2, 2 };

        var result = taskClass.PrimeSubOperation(nums);

        var expected = false;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_PrimeSubtractionOperation();

        var nums = new int[] { 998, 2 };

        var result = taskClass.PrimeSubOperation(nums);

        var expected = true;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_PrimeSubtractionOperation();

        var nums = new int[] { 15, 15, 10 };

        var result = taskClass.PrimeSubOperation(nums);

        var expected = true;

        Assert.Equal(expected, result);
    }
}
