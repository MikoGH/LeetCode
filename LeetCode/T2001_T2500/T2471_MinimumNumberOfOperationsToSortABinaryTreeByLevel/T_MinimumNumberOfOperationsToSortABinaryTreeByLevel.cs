namespace LeetCode.T2001_T2500.T2471_MinimumNumberOfOperationsToSortABinaryTreeByLevel;

public class T_MinimumNumberOfOperationsToSortABinaryTreeByLevel
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

    public class Node
    {
        public int val;
        public int index;

        public Node(int val, int index)
        {
            this.val = val;
            this.index = index;
        }
    }

    public int MinimumOperations(TreeNode root)
    {
        var count = 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var nums = new Node[queue.Count];
            var sortedNums = new Node[queue.Count];
            for (int i = 0; i < nums.Length; i++)
            {
                var treeNode = queue.Dequeue();
                if (treeNode.left is not null)
                    queue.Enqueue(treeNode.left);
                if (treeNode.right is not null)
                    queue.Enqueue(treeNode.right);
                var node = new Node(treeNode.val, i);
                nums[i] = node;
                sortedNums[i] = node;
            }
            Array.Sort(sortedNums, (a, b) => a.val - b.val);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].val == sortedNums[i].val)
                    continue;

                (nums[i], nums[sortedNums[i].index]) = (nums[sortedNums[i].index], nums[i]);
                nums[sortedNums[i].index].index = sortedNums[i].index;
                count++;
            }
        }

        return count;
    }
}
