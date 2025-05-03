using LeetCode.T1001_T1500.T1001_T1100.T1007_MinimumDominoRotationsForEqualRow;

namespace LeetCode.Tests.T1001_T1500;

public class T1007_MinimumDominoRotationsForEqualRow_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MinimumDominoRotationsForEqualRow();

        var tops = new int[] { 2, 1, 2, 4, 2, 2 };
        var bottoms = new int[] { 5, 2, 6, 2, 3, 2 };

        var result = taskClass.MinDominoRotations(tops, bottoms);

        var expected = 2;

        Assert.Equal(expected, result);
    }

}
