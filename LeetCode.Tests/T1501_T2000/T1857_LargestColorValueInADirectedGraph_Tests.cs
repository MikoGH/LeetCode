using LeetCode.T1501_T2000.T1801_T1900.T1857_LargestColorValueInADirectedGraph;

namespace LeetCode.Tests.T1501_T2000;

public class T1857_LargestColorValueInADirectedGraph_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_LargestColorValueInADirectedGraph();

        var colors = "abaca";
        
        var edges = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 } };

        var result = taskClass.LargestPathValue(colors, edges);

        var expected = 3;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_LargestColorValueInADirectedGraph();

        var colors = "hhqhuqhqff";

        var edges = new int[][] { new int[] { 0, 1}, new int[] {0, 2}, new int[] {2, 3}, new int[] {3, 4}, new int[] {3, 5}, new int[] {5, 6}, new int[] {2, 7}, new int[] {6, 7}, new int[] {7, 8}, new int[] {3, 8}, new int[] {5, 8}, new int[] {8, 9}, new int[] {3, 9}, new int[] {6, 9} };

        var result = taskClass.LargestPathValue(colors, edges);

        var expected = 3;

        Assert.Equal(expected, result);
    }
}
