using LeetCode.T2501_T3000.T2924_FindChampionII;

namespace LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        var taskClass = new T_FindChampionII();

        var matrix = new int[4][]
        {
            new int[] { 0, 1 },
            new int[] { 2, 3 },
            new int[] { 2, 4 },
            new int[] { 4, 1 }
        };

        var result = taskClass.FindChampion(5, matrix);

        Console.WriteLine(result);

        Console.ReadLine();
    }
}