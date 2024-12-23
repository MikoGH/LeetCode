namespace LeetCode.T2001_T2500.T2415_ReverseOddLevelsOfBinaryTree;

public class T_ReverseOddLevelsOfBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public TreeNode ReverseOddLevels(TreeNode root)
    {
        GetNextNode(root.left, root.right, 2);

        return root;
    }

    private void GetNextNode(TreeNode left, TreeNode right, int level)
    {
        if (left is null)
            return;

        if (level % 2 == 0)
            (left.val, right.val) = (right.val, left.val);

        GetNextNode(left.left, right.right, level + 1);
        GetNextNode(left.right, right.left, level + 1);
    }
}
