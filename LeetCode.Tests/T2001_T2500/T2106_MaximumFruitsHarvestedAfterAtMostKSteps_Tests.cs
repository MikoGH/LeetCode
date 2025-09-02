using LeetCode.T2001_T2500.T2101_T2200.T2106_MaximumFruitsHarvestedAfterAtMostKSteps;

namespace LeetCode.Tests.T2001_T2500;

public class T2106_MaximumFruitsHarvestedAfterAtMostKSteps_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MaximumFruitsHarvestedAfterAtMostKSteps();

        var fruits = new int[][] { new int[] { 2, 8 }, new int[] { 6, 3 }, new int[] { 8, 6 } };
        var startPos = 5;
        var k = 4;

        var result = taskClass.MaxTotalFruits(fruits, startPos, k);

        var expected = 9;

        Assert.Equal(expected, result);
    }
}
