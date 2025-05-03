namespace LeetCode.T1001_T1500.T1001_T1100.T1007_MinimumDominoRotationsForEqualRow;

public class T_MinimumDominoRotationsForEqualRow
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        var counts = new int[7];
        var rotationsTop = new int[7];
        var rotationsBottom = new int[7];

        for (int i = 0; i < tops.Length; i++)
        {
            if (tops[i] == bottoms[i])
            {
                counts[tops[i]]++;
            }
            else
            {
                counts[tops[i]]++;
                counts[bottoms[i]]++;
                rotationsBottom[bottoms[i]]++;
                rotationsTop[tops[i]]++;
            }
        }

        var result = int.MaxValue;
        for (int i = 1; i <= 6; i++)
        {
            if (counts[i] != tops.Length)
                continue;
            if (rotationsTop[i] < result)
                result = rotationsTop[i];
            if (rotationsBottom[i] < result)
                result = rotationsBottom[i];
        }

        if (result == int.MaxValue)
            return -1;

        return result;
    }
}
