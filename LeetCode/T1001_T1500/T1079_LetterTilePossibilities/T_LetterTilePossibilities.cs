namespace LeetCode.T1001_T1500.T1079_LetterTilePossibilities;

public class T_LetterTilePossibilities
{
    public int NumTilePossibilities(string tiles)
    {
        var letters = new byte[26];

        for (int i = 0; i < tiles.Length; i++)
        {
            letters[tiles[i] - 'A']++;
        }

        var count = CountNumTilePossibilities(letters);

        return count;
    }

    private int CountNumTilePossibilities(byte[] letters)
    {
        var count = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == 0)
                continue;

            count++;
            letters[i]--;
            count += CountNumTilePossibilities(letters);
            letters[i]++;
        }

        return count;
    }
}
