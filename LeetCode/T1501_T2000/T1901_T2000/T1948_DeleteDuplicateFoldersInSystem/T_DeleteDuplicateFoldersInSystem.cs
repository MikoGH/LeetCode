namespace LeetCode.T1501_T2000.T1901_T2000.T1948_DeleteDuplicateFoldersInSystem;

public class T_DeleteDuplicateFoldersInSystem
{
    //private class Node
    //{
    //    public int Count { get; set; }

    //    public int PathIndex { get; set; }

    //    public Dictionary<string, Node> Children { get; set; } = new Dictionary<string, Node>();
    //}

    //public IList<IList<string>> DeleteDuplicateFolder(IList<IList<string>> paths)
    //{
    //    var root = new Node();

    //    for (int pathIndex = 0; pathIndex < paths.Count; pathIndex++)
    //    {
    //        var path = paths[pathIndex];

    //        var node = root;
    //        for (int i = path.Count - 1; i >= 0; i--)
    //        {
    //            if (!node.Children.TryGetValue(path[i], out var childNode))
    //            {
    //                childNode = new Node();
    //                node.Children.Add(path[i], childNode);
    //            }

    //            node = childNode;
    //            node.Count++;
    //            node.PathIndex = pathIndex;
    //        }
    //    }

    //    var marked = new bool[paths.Count];
    //    foreach (var node in root.Children.Values)
    //    {
    //        if (node.Count > 1)
    //            Dfs(marked, node);
    //    }

    //    var result = new List<IList<string>>();
    //    for (int i = 0; i < paths.Count; i++)
    //    {
    //        if (!marked[i])
    //            result.Add(paths[i]);
    //    }

    //    return result;
    //}

    //private void Dfs(bool[] marked, Node node)
    //{
    //    if (node.Count == 1)
    //    {
    //        marked[node.PathIndex] = true;
    //        return;
    //    }

    //    foreach (var child in node.Children.Values)
    //    {
    //        Dfs(marked, child);
    //    }
    //}
}
