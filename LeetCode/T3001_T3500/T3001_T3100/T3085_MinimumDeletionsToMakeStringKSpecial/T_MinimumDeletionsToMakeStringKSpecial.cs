namespace LeetCode.T3001_T3500.T3001_T3100.T3085_MinimumDeletionsToMakeStringKSpecial;

public class T_MinimumDeletionsToMakeStringKSpecial
{
    public int MinimumDeletions(string word, int k)
    {
        var counts = new int[26];
        
        foreach (var smb in word)
        {
            counts[smb - 'a']++;
        }

        var result = word.Length;
        for (int i = 0; i < counts.Length; i++)
        {
            var del = 0;
            for (int j = 0; j < counts.Length; j++)
            {
                if (counts[i] > counts[j])
                {
                    del += counts[j];
                }
                else if (counts[j] - counts[i] > k)
                {
                    del += counts[j] - counts[i] - k;
                }
            }
            result = Math.Min(result, del);
        }

        return result;

        //Array.Sort(counts);

        //var i = 0;
        //while (counts[i] == 0)
        //    i++;

        //var min = counts[i];

        //var result = 0;

        //i = counts.Length - 1;
        //while (counts[i] - min > k)
        //{
        //    result += counts[i] - min - k;
        //    i--;
        //}

        //return result;
    }
}
