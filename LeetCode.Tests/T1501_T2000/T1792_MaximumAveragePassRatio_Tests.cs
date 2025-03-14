using LeetCode.T1501_T2000.T1701_T1800.T1792_MaximumAveragePassRatio;

namespace LeetCode.Tests.T1501_T2000;

public class T1792_MaximumAveragePassRatio_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MaximumAveragePassRatio();

        var classes = new int[3][]
        {
            new int[] { 1, 2 },
            new int[] { 3, 5 },
            new int[] { 2, 2 }
        };

        var extraStudents = 2;

        var result = taskClass.MaxAverageRatio(classes, extraStudents);

        var expected = 0.78333333333333333;

        Assert.Equal(expected, result);
    }
}
