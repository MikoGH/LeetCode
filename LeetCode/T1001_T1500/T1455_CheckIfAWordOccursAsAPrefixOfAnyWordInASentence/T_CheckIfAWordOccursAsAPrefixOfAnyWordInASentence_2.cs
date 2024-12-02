namespace LeetCode.T1001_T1500.T1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence;

public class T_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_2
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        int j = 0;
        var flag = true;
        var count = 1;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (j < searchWord.Length && sentence[i] != searchWord[j])
                flag = false;
            else if (j + 1 == searchWord.Length && flag == true)
                    return count;

            if (sentence[i] == ' ')
            {
                flag = true;
                j = 0;
                count++;
                continue;
            }

            j++;
        }

        return -1;
    }
}
