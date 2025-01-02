namespace LeetCode.T0001_T0500.T0126_WordLadderII;

public class T_WordLadder
{
    private class Node
    {
        public long[] PatternHashes { get; set; }
        public string Word { get; set; }
        public int Depth { get; set; } = int.MaxValue;
        //public int Count { get; set; } = 0;
        //public List<Node> PreviousNodes { get; set; } = new List<Node>();

        public Node(string word)
        {
            Word = word;
            PatternHashes = new long[Word.Length];
            for (int i = 0; i < Word.Length; i++)
                PatternHashes[i] = GetPatternHash(Word, i);
        }

        private long GetPatternHash(string s, int anyIndex)
        {
            long hash = 0;

            var anySymbol = 28;
            for (var i = 0; i < s.Length; i++)
                hash += (i == anyIndex ? anySymbol : s[i] - 'a' + 1) * pows[i];

            return hash;
        }
    }

    private static long k = 29;
    private static long[] pows = Enumerable.Range(0, 10).Select(x => (long)Math.Pow(k, x)).ToArray();

    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        if (!wordList.Contains(endWord))
            return 0;

        if (!wordList.Contains(beginWord))
            wordList.Add(beginWord);

        var nodes = wordList.ToDictionary(
                x => x,
                x => new Node(x));

        var wordSize = beginWord.Length;
        var connections = Enumerable.Range(0, wordSize)
            .Select(anyIndex => nodes.Values
                .GroupBy(
                    node => node.PatternHashes[anyIndex],
                    node => node.Word))
            .SelectMany(x => x)
            .ToDictionary(
                x => x.Key,
                x => x.ToList());

        var queue = new Queue<Node>();
        queue.Enqueue(nodes[beginWord]);
        //nodes[beginWord].Count = 1;
        nodes[beginWord].Depth = 0;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            foreach (var hash in node.PatternHashes)
            {
                foreach (var word in connections[hash])
                {
                    if (word.Equals(endWord))
                        return node.Depth + 1;

                    if (word == node.Word || nodes[word].Depth < node.Depth + 1 || nodes[word].Depth != int.MaxValue)
                        continue;

                    //var visited = nodes[word].Depth != int.MaxValue;
                    nodes[word].Depth = node.Depth + 1;
                    //nodes[word].PreviousNodes.Add(node);
                    //nodes[word].Count += node.Count;
                    //if (!visited)
                    queue.Enqueue(nodes[word]);
                }
            }
        }

        //if (nodes[endWord].Depth == int.MaxValue)
        return 0;

        //return nodes[endWord].Depth + 1;
    }
}
