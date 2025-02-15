using LeetCode.T1001_T1500.T1352_ProductOfTheLastKNumbers;

namespace LeetCode.Tests.T1001_T1500;

public class T1352_ProductOfTheLastKNumbers_Tests
{
    delegate void AddDelegate(int num);

    delegate int GetProductDelegate(int k);

    [Fact]
    public void Test01()
    {
        var taskClass = new T_ProductOfTheLastKNumbers();

        var funcsAdd = new AddDelegate?[] { taskClass.Add, taskClass.Add, taskClass.Add, taskClass.Add, taskClass.Add, null, null, null, taskClass.Add, null };

        var funcsGetProduct = new GetProductDelegate?[] { null, null, null, null, null, taskClass.GetProduct, taskClass.GetProduct, taskClass.GetProduct, null, taskClass.GetProduct };

        var values = new int[] { 3, 0, 2, 5, 4, 2, 3, 4, 8, 2 };

        var result = new int?[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            if (funcsGetProduct[i] is not null)
            {
                result[i] = funcsGetProduct[i](values[i]);
            }
            else
            {
                result[i] = null;
                funcsAdd[i](values[i]);
            }
        }

        var expected = new int?[] { null, null, null, null, null, 20, 40, 0, null, 32 };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_ProductOfTheLastKNumbers();

        var funcsAdd = new AddDelegate?[] { taskClass.Add, taskClass.Add, taskClass.Add, taskClass.Add, null, null, taskClass.Add, taskClass.Add, taskClass.Add, null, null, taskClass.Add, taskClass.Add, null, null, null, null, taskClass.Add, taskClass.Add, taskClass.Add, taskClass.Add, null, null, null, taskClass.Add, taskClass.Add, taskClass.Add, taskClass.Add, null, taskClass.Add, null, taskClass.Add, taskClass.Add, taskClass.Add, taskClass.Add, null, null, taskClass.Add, null };

        var funcsGetProduct = new GetProductDelegate?[] { null, null, null, null, taskClass.GetProduct, taskClass.GetProduct, null, null, null, taskClass.GetProduct, taskClass.GetProduct, null, null, taskClass.GetProduct, taskClass.GetProduct, taskClass.GetProduct, taskClass.GetProduct, null, null, null, null, taskClass.GetProduct, taskClass.GetProduct, taskClass.GetProduct, null, null, null, null, taskClass.GetProduct, null, taskClass.GetProduct, null, null, null, null, taskClass.GetProduct, taskClass.GetProduct, null, taskClass.GetProduct };

        var values = new int[] { 76, 96, 87, 63, 3, 1, 12, 0, 29, 4, 7, 29, 36, 9, 4, 5, 8, 27, 5, 0, 61, 7, 4, 3, 3, 49, 85, 72, 9, 10, 10, 0, 68, 67, 5, 4, 3, 3, 49 };

        var result = new int?[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            if (funcsGetProduct[i] is not null)
            {
                result[i] = funcsGetProduct[i](values[i]);
            }
            else
            {
                result[i] = null;
                funcsAdd[i](values[i]);
            }
        }

        var expected = new int?[] { null, null, null, null, 526176, 63, null, null, null, 0, 0, null, null, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, null, null, null, null, 0, null, 0, null, null, null, null, 0, 22780, null, 0 };

        Assert.Equal(expected, result);
    }
}
