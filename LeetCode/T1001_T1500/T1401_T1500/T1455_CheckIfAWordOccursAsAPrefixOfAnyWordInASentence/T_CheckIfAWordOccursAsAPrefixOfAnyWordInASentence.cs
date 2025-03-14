namespace LeetCode.T1001_T1500.T1401_T1500.T1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence;

public class T_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var result = sentence.Split(' ').Select(x => x.StartsWith(searchWord)).ToList().IndexOf(true);

        if (result == -1)
            return -1;

        return result + 1;
    }
}
