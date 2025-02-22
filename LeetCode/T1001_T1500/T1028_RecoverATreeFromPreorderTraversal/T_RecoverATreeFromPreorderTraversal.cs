namespace LeetCode.T1001_T1500.T1028_RecoverATreeFromPreorderTraversal;

public class T_RecoverATreeFromPreorderTraversal
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
    private int _index = 1;

    public TreeNode RecoverFromPreorder(string traversal)
    {
        var nodes = new List<(int Depth, TreeNode Node)>(1001);

        var index = 0;
        while (index < traversal.Length)
        {
            var dashes = 0;
            while (traversal[index] == '-')
            {
                dashes++;
                index++;
            }
            var nextIndex = index;
            while (nextIndex < traversal.Length && traversal[nextIndex] != '-')
            {
                nextIndex++;
            }
            var number = int.Parse(traversal.Substring(index, nextIndex - index));
            nodes.Add((dashes, new TreeNode(number)));
            index = nextIndex;
        }

        var root = nodes[0].Node;
        Recover(nodes, root, 1);

        return root;
    }

    public void Recover(List<(int Depth, TreeNode Node)> nodes, TreeNode parentNode, int depth)
    {
        if (_index >= nodes.Count || nodes[_index].Depth < depth)
            return;

        parentNode.left = nodes[_index++].Node;

        if (_index >= nodes.Count || nodes[_index].Depth < depth)
            return;

        Recover(nodes, nodes[_index - 1].Node, depth + 1);

        if (_index >= nodes.Count || nodes[_index].Depth < depth)
            return;

        parentNode.right = nodes[_index++].Node;

        if (_index >= nodes.Count || nodes[_index].Depth < depth)
            return;

        Recover(nodes, nodes[_index - 1].Node, depth + 1);
    }
}
