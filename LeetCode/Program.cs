using LeetCode.T0001_T0500.T0085_MaximalRectangle;

namespace LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        var taskClass = new T_MaximalRectangle();

        var matrix = new char[4][]
        {
            new char[] { '1', '0', '1', '0', '0' },
            new char[] { '1', '0', '1', '1', '1' },
            new char[] { '1', '1', '1', '1', '1' },
            new char[] { '1', '0', '0', '1', '0' }
        };

        //var matrix = new char[3][]
        //{
        //    new char[] { '0', '0', '0', '0', '0' },
        //    new char[] { '0', '0', '0', '0', '0' },
        //    new char[] { '1', '1', '1', '1', '1' }
        //};

        var result = taskClass.MaximalRectangle(matrix);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}