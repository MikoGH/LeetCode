namespace LeetCode.T1001_T1500.T1201_T1300.T1261_FindElementsInAContaminatedBinaryTree;

public class T_FindElementsInAContaminatedBinaryTree2
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
        private TreeNode _root;

        public FindElements(TreeNode root)
        {
            _root = root;
        }

        public bool Find(int target)
        {
            target++;
            var depth = int.Log2(target);
            var node = _root;

            var l = 1 << depth;
            var r = 1 << depth + 1;
            while (l + 1 < r)
            {
                var s = l + r >> 1;

                if (target >= s)
                {
                    l = s;
                    node = node.right;
                }
                else
                {
                    r = s;
                    node = node.left;
                }

                if (node is null)
                    return false;
            }

            return true;
        }
    }
}
