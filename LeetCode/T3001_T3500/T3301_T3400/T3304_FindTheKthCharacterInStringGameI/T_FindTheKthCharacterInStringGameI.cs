namespace LeetCode.T3001_T3500.T3301_T3400.T3304_FindTheKthCharacterInStringGameI;

public class T_FindTheKthCharacterInStringGameI
{
    public char KthCharacter(int k)
    {
        var smbs = new int[k * 2];
        smbs[0] = 0;
        var i = 1;

        while (i < k)
        {
            for (int j = 0; j < i; j++)
            {
                smbs[i + j] = (smbs[j] + 1) % 26;
            }

            i <<= 1;
        }

        return (char)(smbs[k - 1] + 'a');
    }
}
