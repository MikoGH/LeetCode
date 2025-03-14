namespace LeetCode.T0501_T1000.T0801_T0900.T0889_ConstructBinaryTreeFromPreorderAndPostorderTraversal;

public class T_ConstructBinaryTreeFromPreorderAndPostorderTraversal
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

    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
    {
        var root = new TreeNode(preorder[0]);

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        var indexPreorder = 1;
        var indexPostorder = 0;

        while (indexPreorder < preorder.Length)
        {
            var node = stack.Peek();

            var nextNode = new TreeNode(preorder[indexPreorder++]);

            if (node.left is null)
                node.left = nextNode;
            else
                node.right = nextNode;

            stack.Push(nextNode);

            while (stack.Count > 0 && stack.Peek().val == postorder[indexPostorder])
            {
                indexPostorder++;
                stack.Pop();
            }
        }

        return root;
    }
}
