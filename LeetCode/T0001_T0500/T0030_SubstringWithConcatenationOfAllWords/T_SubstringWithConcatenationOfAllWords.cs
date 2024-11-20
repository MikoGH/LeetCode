namespace LeetCode.T0001_T0500.T0030_SubstringWithConcatenationOfAllWords;

public class T_SubstringWithConcatenationOfAllWords
{
    private const char _endSymbol = '$';
    private record struct Node(char Letter)
    {
        public char Letter { get; } = Letter;
        public Dictionary<char, Node> NextNodes { get; } = new Dictionary<char, Node>();
        //public short Count { get; set; } = 0;
        public short WordIndex { get; set; }
    }

    public IList<int> FindSubstring(string s, string[] words)
    {
        var root = SetNodes(words);

        throw new NotImplementedException();
    }

    private Node SetNodes(string[] words)
    {
        var root = new Node();
        var length = words[0].Length;

        foreach (var word in words)
        {
            var node = root;
            foreach (var letter in word)
            {
                if (node.NextNodes.ContainsKey(letter))
                {
                    node = node.NextNodes[letter];
                    continue;
                }
                var newNode = new Node(letter);
                node.NextNodes[letter] = newNode;
                node = newNode;
            }
            //if (node.NextNodes.ContainsKey(_endSymbol))
            //{
            //    node = node.NextNodes[_endSymbol];
            //    node.Count++;
            //    continue;
            //}
            if (node.NextNodes.ContainsKey(_endSymbol))
                continue;
            var endNode = new Node(_endSymbol);
            node.NextNodes[_endSymbol] = endNode;
        }

        return root;
    }

    private int GetWord(int startIndex)
    {
        return -1;
    }
}
