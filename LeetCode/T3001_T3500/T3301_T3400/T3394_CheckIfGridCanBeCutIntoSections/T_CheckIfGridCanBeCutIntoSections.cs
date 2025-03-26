namespace LeetCode.T3001_T3500.T3301_T3400.T3394_CheckIfGridCanBeCutIntoSections;

public class T_CheckIfGridCanBeCutIntoSections
{
    public bool CheckValidCuts(int n, int[][] rectangles)
    {
        var sortedByStartX = rectangles.Select(x => x[0]).Order().ToArray();
        var sortedByEndX = rectangles.Select(x => x[2]).Order().ToArray();
        var sortedByStartY = rectangles.Select(x => x[1]).Order().ToArray();
        var sortedByEndY = rectangles.Select(x => x[3]).Order().ToArray();

        var result = Check(sortedByStartX.Length, sortedByStartX, sortedByEndX);
        if (result)
            return true;

        result = Check(sortedByStartX.Length, sortedByStartY, sortedByEndY);

        return result;
    }

    private bool Check(int length, int[] sortedByStart, int[] sortedByEnd)
    {
        var i = 0; var j = 0;
        var count = 0;
        var cuts = 0;
        while (i < length && j < length)
        {
            if (i < length && sortedByStart[i] < sortedByEnd[j])
            {
                count++;
                i++;
                continue;
            }

            count--;
            j++;
            if (count == 0)
            {
                cuts++;
                if (cuts == 2)
                    return true;
            }
        }

        return false;
    }
}
