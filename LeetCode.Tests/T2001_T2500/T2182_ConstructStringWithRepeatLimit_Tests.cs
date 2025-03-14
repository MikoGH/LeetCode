using LeetCode.T2001_T2500.T2101_T2200.T2182_ConstructStringWithRepeatLimit;

namespace LeetCode.Tests.T2001_T2500;

public class T2182_ConstructStringWithRepeatLimit_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ConstructStringWithRepeatLimit();

        var s = "cczazcc";

        var repeatLimit = 3;

        var result = taskClass.RepeatLimitedString(s, repeatLimit);

        var expected = "zzcccac";

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_ConstructStringWithRepeatLimit();

        var s = "xyutfpopdynbadwtvmxiemmusevduloxwvpkjioizvanetecnuqbqqdtrwrkgt";

        var repeatLimit = 1;

        var result = taskClass.RepeatLimitedString(s, repeatLimit);

        //var expected = "zzcccac";

        //Assert.Equal(expected, result);
    }
}
