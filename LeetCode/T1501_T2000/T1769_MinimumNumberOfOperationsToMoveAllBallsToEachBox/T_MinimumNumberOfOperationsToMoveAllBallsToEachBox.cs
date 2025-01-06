namespace LeetCode.T1501_T2000.T1769_MinimumNumberOfOperationsToMoveAllBallsToEachBox;

public class T_MinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    public int[] MinOperations(string boxes)
    {
        var result = new int[boxes.Length];
        var count = 0;
        var balls = 0;

        for (int i = 0; i < boxes.Length; i++)
        {
            count += balls;
            result[i] += count;
            if (boxes[i] == '1')
                balls++;
        }

        count = 0;
        balls = 0;

        for (int i = boxes.Length - 1; i >= 0; i--)
        {
            count += balls;
            result[i] += count;
            if (boxes[i] == '1')
                balls++;
        }

        return result;
    }
}
