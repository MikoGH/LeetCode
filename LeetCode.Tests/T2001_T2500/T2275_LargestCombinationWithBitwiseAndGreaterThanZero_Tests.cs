using LeetCode.T2001_T2500.T2201_T2300.T2275_LargestCombinationWithBitwiseAndGreaterThanZero;

namespace LeetCode.Tests.T2001_T2500;

public class T2275_LargestCombinationWithBitwiseAndGreaterThanZero_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_LargestCombinationWithBitwiseAndGreaterThanZero_2();

        var nums = new int[7] { 16, 17, 71, 62, 12, 24, 14 };

        var result = taskClass.LargestCombination(nums);

        var expected = 4;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_LargestCombinationWithBitwiseAndGreaterThanZero_2();

        var nums = new int[30] { 33, 93, 31, 99, 74, 37, 3, 4, 2, 94, 77, 10, 75, 54, 24, 95, 65, 100, 41, 82, 35, 65, 38, 49, 85, 72, 67, 21, 20, 31 };

        var result = taskClass.LargestCombination(nums);

        var expected = 18;

        Assert.Equal(expected, result);
    }
}
