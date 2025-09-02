using LeetCode.T1001_T1500.T1201_T1300.T1277_CountSquareSubmatricesWithAllOne;

namespace LeetCode.Tests.T1001_T1500;

public class T1277_CountSquareSubmatricesWithAllOne_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_CountSquareSubmatricesWithAllOne();

        var matrix = new int[3][]
            {
              new int[] { 0, 1, 1, 1 },
              new int[] { 1, 1, 1, 1 },
              new int[] { 0, 1, 1, 1 }
            };

        var result = taskClass.CountSquares(matrix);

        var expected = 15;

        Assert.Equal(expected, result);
    }
}
