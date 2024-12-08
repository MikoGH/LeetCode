using LeetCode.T2001_T2500.T2054_TwoBestNonOverlappingEvents;

namespace LeetCode.Tests.T2001_T2500;

public class T2054_TwoBestNonOverlappingEvents_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_TwoBestNonOverlappingEvents();

        var nums = new int[3][] {
            new int[] { 1, 3, 2 },
            new int[] { 4, 5, 2 },
            new int[] { 2, 4, 3 }
        };

        var result = taskClass.MaxTwoEvents(nums);

        var expected = 4;

        Assert.Equal(expected, result);
    }


    [Fact]
    public void Test02()
    {
        var taskClass = new T_TwoBestNonOverlappingEvents();

        var nums = new int[9][] {
            new int[] {22,44,9},
            new int[] {93,96,48},
            new int[] {56,90,3},
            new int[] {80,92,45},
            new int[] {63,73,69},
            new int[] {73,96,33},
            new int[] {11,23,84},
            new int[] {59,72,29},
            new int[] {89,100,46}
        };

        var result = taskClass.MaxTwoEvents(nums);

        var expected = 153;

        Assert.Equal(expected, result);
    }
}
