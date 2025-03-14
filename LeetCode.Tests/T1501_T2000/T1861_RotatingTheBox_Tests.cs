using LeetCode.T1501_T2000.T1801_T1900.T1861_RotatingTheBox;

namespace LeetCode.Tests.T1501_T2000;

public class T1861_RotatingTheBox_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_RotatingTheBox();

        var box = new char[1][] {
            new char[] { '#', '.', '#' }
        };

        var result = taskClass.RotateTheBox(box);

        var expected = new char[3][] {
            new char[] { '.' },
            new char[] { '#' },
            new char[] { '#' }
        };

        Assert.Equal(expected, result);
    }
}
