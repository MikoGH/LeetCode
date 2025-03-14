namespace LeetCode.T1001_T1500.T1401_T1500.T1462_CourseScheduleIV;

public class T_CourseScheduleIV
{
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
    {
        var adjacent = new Dictionary<int, List<int>>();

        foreach (var edge in prerequisites)
        {
            if (!adjacent.ContainsKey(edge[0]))
                adjacent.Add(edge[0], new List<int>());
            adjacent[edge[0]].Add(edge[1]);
        }

        var result = new bool[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            var visited = new bool[numCourses];
            result[i] = IsPrerequisite(adjacent, visited, queries[i][0], queries[i][1]);
        }

        return result;
    }

    private bool IsPrerequisite(Dictionary<int, List<int>> adjacent, bool[] visited, int from, int to)
    {
        visited[from] = true;

        if (from == to) return true;

        var result = false;

        var neighbors = adjacent.GetValueOrDefault(from);

        if (neighbors is null) return false;

        foreach (var neighbor in neighbors)
        {
            if (!visited[neighbor])
            {
                result |= IsPrerequisite(adjacent, visited, neighbor, to);
            }
        }

        return result;
    }
    //var indirectPrerequisites = new HashSet<int>[numCourses];
    //var prerequisitesDictionary = prerequisites.GroupBy(x => x[1], x => x[0]).ToDictionary(x => x.Key, x => x);
    //var courses = prerequisites.Select(x => x[0]).ToHashSet();

    //var queue = new Queue<int>();
    //for (int i = 0; i < numCourses; i++)
    //{
    //    if (!courses.Contains(i))
    //    {
    //        queue.Enqueue(i);
    //        indirectPrerequisites[i] = new HashSet<int>();
    //    }
    //}

    //while (queue.Count > 0)
    //{
    //    var course = queue.Dequeue();

    //    foreach (var prerequisiteCourse in prerequisitesDictionary[course])
    //    {

    //    }
    //}
}
