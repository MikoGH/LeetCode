using LeetCode.T2001_T2500.T2201_T2300.T2290_MinimumObstacleRemovalToReachCorner;

namespace LeetCode.Tests.T2001_T2500;

public class T2290_MinimumObstacleRemovalToReachCorner_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MinimumObstacleRemovalToReachCorner();

        var nums = new int[3][] {
            new int[] { 0, 1, 1 },
            new int[] { 1, 1, 0 },
            new int[] { 1, 1, 0 }
        };

        var result = taskClass.MinimumObstacles(nums);

        var expected = 2;

        Assert.Equal(expected, result);
    }
}
