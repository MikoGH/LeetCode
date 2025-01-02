using LeetCode.T0001_T0500.T0126_WordLadderII;

namespace LeetCode.Tests.T0001_T0500;

public class T0127_WordLadder_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_WordLadder();

        var beginWord = "hot";
        var endWord = "dog";
        var wordList = new List<string> { "hot", "dog" };

        var result = taskClass.LadderLength(beginWord, endWord, wordList);

        var expected = 0;

        Assert.Equal(expected, result);
    }
}
