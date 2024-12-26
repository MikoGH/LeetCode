namespace LeetCode.T0501_T1000.T0515_FindLargestValueInEachTreeRow;

public class T_FindLargestValueInEachTreeRow
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    private List<int> result = new List<int>();

    public IList<int> LargestValues(TreeNode root)
    {
        if (root is not null)
            Dfs(root, 0);

        return result;
    }

    private void Dfs(TreeNode node, int depth)
    {
        if (result.Count <= depth)
            result.Add(int.MinValue);

        if (node.val > result[depth])
            result[depth] = node.val;

        if (node.left is not null)
            Dfs(node.left, depth + 1);
        if (node.right is not null)
            Dfs(node.right, depth + 1);
    }
}
