using LeetCode.T2001_T2500.T2401_T2500.T2402_MeetingRoomsIII;

namespace LeetCode.Tests.T2001_T2500;

public class T2402_MeetingRoomsIII_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MeetingRoomsIII();

        var meetings = new int[][] {
            new int[] { 0, 10 },
            new int[] { 1, 5 },
            new int[] { 2, 7 },
            new int[] { 3, 4 }
        };

        var n = 2;

        var result = taskClass.MostBooked(n, meetings);

        var expected = 0;

        Assert.Equal(expected, result);
    }
}
