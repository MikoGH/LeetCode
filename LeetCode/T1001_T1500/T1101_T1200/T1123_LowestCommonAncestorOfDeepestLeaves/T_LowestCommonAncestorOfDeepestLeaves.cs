namespace LeetCode.T1001_T1500.T1101_T1200.T1123_LowestCommonAncestorOfDeepestLeaves;

public class T_LowestCommonAncestorOfDeepestLeaves
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    TreeNode _result;
    int _maxDepth = 0;

    public TreeNode LcaDeepestLeaves(TreeNode root)
    {
        _result = root;

        Dfs(root, 0);

        return _result;
    }

    private int Dfs(TreeNode node, int depth)
    {
        var leftDepth = 0;
        if (node.left is not null)
            leftDepth = Dfs(node.left, depth + 1);

        var rightDepth = 0;
        if (node.right is not null)
            rightDepth = Dfs(node.right, depth + 1);

        if (depth > _maxDepth)
        {
            _maxDepth = depth;
            _result = node;
        }
        if (leftDepth == rightDepth && rightDepth == _maxDepth)
            _result = node;

        return Math.Max(Math.Max(leftDepth, rightDepth), depth);
    }
}
