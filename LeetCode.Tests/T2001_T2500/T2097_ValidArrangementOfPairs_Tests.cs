using LeetCode.T2001_T2500.T2001_T2100.T2097_ValidArrangementOfPairs;

namespace LeetCode.Tests.T2001_T2500;

public class T2097_ValidArrangementOfPairs_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ValidArrangementOfPairs();

        var nums = new int[7][] {
            new int[] { 1, 2 },
            new int[] { 2, 4 },
            new int[] { 4, 1 },
            new int[] { 1, 7 },
            new int[] { 1, 4 },
            new int[] { 7, 2 },
            new int[] { 2, 1 }
        };

        var result = taskClass.ValidArrangement(nums);

        //var expected = new int[7][] {
        //    new int[] { 1, 2 },
        //    new int[] { 2, 4 },
        //    new int[] { 4, 1 },
        //    new int[] { 1, 7 },
        //    new int[] { 7, 2 },
        //    new int[] { 2, 1 },
        //    new int[] { 1, 4 }
        //};

        //Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_ValidArrangementOfPairs();

        var nums = new int[9][] {
            new int[] { 8, 5 },
            new int[] { 8, 7 },
            new int[] { 0, 8 },
            new int[] { 0, 5 },
            new int[] { 7, 0 },
            new int[] { 5, 0 },
            new int[] { 0, 7 },
            new int[] { 8, 0 },
            new int[] { 7, 8 }
        };

        var result = taskClass.ValidArrangement(nums);

        //var expected = new int[7][] {
        //    new int[] { 1, 2 },
        //    new int[] { 2, 4 },
        //    new int[] { 4, 1 },
        //    new int[] { 1, 7 },
        //    new int[] { 7, 2 },
        //    new int[] { 2, 1 },
        //    new int[] { 1, 4 }
        //};

        //Assert.Equal(expected, result);
    }
}
