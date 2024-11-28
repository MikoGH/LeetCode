using LeetCode.T3001_T3500.T3243_ShortestDistanceAfterRoadAdditionQueriesI;

namespace LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        var taskClass = new T_ShortestDistanceAfterRoadAdditionQueriesI();

        var matrix = new int[4][]
        {
            new int[] { 0, 1 },
            new int[] { 2, 3 },
            new int[] { 2, 4 },
            new int[] { 4, 1 }
        };

        var result = taskClass.ShortestDistanceAfterQueries(5, matrix);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}