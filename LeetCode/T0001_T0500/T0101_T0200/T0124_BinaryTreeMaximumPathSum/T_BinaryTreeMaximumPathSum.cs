namespace LeetCode.T0001_T0500.T0101_T0200.T0124_BinaryTreeMaximumPathSum;

public class T_BinaryTreeMaximumPathSum
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

    private int _result = 0;
    private int _totalMax = int.MinValue;

    public int MaxPathSum(TreeNode root)
    {
        GetMax(root);

        if (_result == 0)
            return _totalMax;

        return _result;
    }

    public int GetMax(TreeNode node)
    {
        int leftMax = 0;
        int rightMax = 0;
        if (node.left is not null)
            leftMax = GetMax(node.left);
        if (node.right is not null)
            rightMax = GetMax(node.right);

        _result = Math.Max(Math.Max(_result, leftMax + rightMax + node.val), Math.Max(leftMax, rightMax) + node.val);
        _totalMax = Math.Max(_totalMax, node.val);

        return Math.Max(0, Math.Max(leftMax, rightMax) + node.val);
    }
}
