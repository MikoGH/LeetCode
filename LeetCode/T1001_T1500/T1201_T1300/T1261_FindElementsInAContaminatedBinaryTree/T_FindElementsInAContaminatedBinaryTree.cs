namespace LeetCode.T1001_T1500.T1201_T1300.T1261_FindElementsInAContaminatedBinaryTree;

public class T_FindElementsInAContaminatedBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class FindElements
    {
        private bool[] _values = new bool[(int)10e6 + 1];

        public FindElements(TreeNode root)
        {
            Set(root, 0);
        }

        private void Set(TreeNode root, int value)
        {
            if (value < _values.Length)
                _values[value] = true;

            if (root.left != null)
                Set(root.left, value * 2 + 1);

            if (root.right != null)
                Set(root.right, value * 2 + 2);
        }

        public bool Find(int target)
        {
            return _values[target];
        }
    }
}
