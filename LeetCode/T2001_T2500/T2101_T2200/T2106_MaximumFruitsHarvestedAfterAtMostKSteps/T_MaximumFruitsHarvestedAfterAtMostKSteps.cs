namespace LeetCode.T2001_T2500.T2101_T2200.T2106_MaximumFruitsHarvestedAfterAtMostKSteps;

public class T_MaximumFruitsHarvestedAfterAtMostKSteps
{
    public int MaxTotalFruits(int[][] fruits, int startPos, int k)
    {
        var firstLeftFruitPos = -1;
        var firstRightFruitPos = -1;
        if (fruits[0][0] <= startPos)
            firstLeftFruitPos = 0;
        if (fruits[0][0] >= startPos)
            firstRightFruitPos = 0;
        for (int i = 1; i < fruits.Length; i++)
        {
            fruits[i][1] += fruits[i - 1][1];
            if (fruits[i][0] <= startPos)
                firstLeftFruitPos = i;
            if (firstRightFruitPos == -1 && fruits[i][0] >= startPos)
                firstRightFruitPos = i;
        }

        var maxCount = 0;
        if (firstLeftFruitPos != -1)
        {
            for (int leftPos = firstLeftFruitPos; leftPos >= 0; leftPos--)
            {
                if (startPos - fruits[leftPos][0] > k)
                    break;
                var kRemained = k - 2 * (startPos - fruits[leftPos][0]);
                var rightPos = BinarySearch(fruits, startPos + (kRemained > 0 ? kRemained : 0), false);
                var count = leftPos == 0 ? fruits[rightPos][1] : fruits[rightPos][1] - fruits[leftPos - 1][1];
                if (count > maxCount)
                    maxCount = count;
            }
        }
        if (firstRightFruitPos != -1)
        {
            for (int rightPos = firstRightFruitPos; rightPos < fruits.Length; rightPos++)
            {
                if (fruits[rightPos][0] - startPos > k)
                    break;
                var kRemained = k - 2 * (fruits[rightPos][0] - startPos);
                var leftPos = BinarySearch(fruits, startPos - (kRemained > 0 ? kRemained : 0), true);
                var count = leftPos == 0 ? fruits[rightPos][1] : fruits[rightPos][1] - fruits[leftPos - 1][1];
                if (count > maxCount)
                    maxCount = count;
            }
        }

        return maxCount;
    }

    public int BinarySearch(int[][] fruits, int position, bool beforeStartPos)
    {
        var l = beforeStartPos ? -1 : 0;
        var r = beforeStartPos ? fruits.Length - 1 : fruits.Length;
        while (l + 1 < r)
        {
            var s = (l + r) >> 1;
            if (position < fruits[s][0])
            {
                r = s;
            }
            else if (position > fruits[s][0])
            {
                l = s;
            }
            else if (beforeStartPos)
            {
                r = s;
            }
            else
            {
                l = s;
            }
        }

        if (beforeStartPos)
            return r;
        else
            return l;
    }
}
