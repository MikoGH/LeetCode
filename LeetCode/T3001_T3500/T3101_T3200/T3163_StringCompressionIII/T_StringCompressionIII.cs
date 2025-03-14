using System.Text;

namespace LeetCode.T3001_T3500.T3101_T3200.T3163_StringCompressionIII;

public class T_StringCompressionIII
{
    public string CompressedString(string word)
    {
        var compStringBuilder = new StringBuilder();
        var count = 1;
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] == word[i + 1] || count == 0)
                count++;
            if (count == 10)
            {
                compStringBuilder.Append("9");
                compStringBuilder.Append(word[i]);
                count = 1;
            }
            if (!(word[i] == word[i + 1]))
            {
                compStringBuilder.Append(count.ToString());
                compStringBuilder.Append(word[i]);
                count = 1;
            }
        }

        compStringBuilder.Append(count.ToString());
        compStringBuilder.Append(word[word.Length - 1]);

        return compStringBuilder.ToString();
    }
}
