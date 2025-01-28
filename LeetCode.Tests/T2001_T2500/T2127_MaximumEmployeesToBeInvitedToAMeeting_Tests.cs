using LeetCode.T2001_T2500.T2127_MaximumEmployeesToBeInvitedToAMeeting;

namespace LeetCode.Tests.T2001_T2500;

public class T2127_MaximumEmployeesToBeInvitedToAMeeting_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MaximumEmployeesToBeInvitedToAMeeting();

        var favourite = new int[] { 2, 2, 1, 2 };

        var result = taskClass.MaximumInvitations(favourite);

        var expected = 3;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_MaximumEmployeesToBeInvitedToAMeeting();

        var favourite = new int[] { 6, 4, 4, 5, 0, 3, 3 };

        var result = taskClass.MaximumInvitations(favourite);

        var expected = 6;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_MaximumEmployeesToBeInvitedToAMeeting();

        var favourite = new int[] { 3, 0, 1, 4, 1 };

        var result = taskClass.MaximumInvitations(favourite);

        var expected = 4;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_MaximumEmployeesToBeInvitedToAMeeting();

        var favourite = new int[] { 1, 0, 0, 2, 1, 4, 7, 8, 9, 6, 7, 10, 8 };

        var result = taskClass.MaximumInvitations(favourite);

        var expected = 6;

        Assert.Equal(expected, result);
    }
}
