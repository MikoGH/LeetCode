namespace LeetCode.T1001_T1500.T1201_T1300.T1298_MaximumCandiesYouCanGetFromBoxes;

public class T_MaximumCandiesYouCanGetFromBoxes
{
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes)
    {
        var result = 0;

        foreach (var initialBox in initialBoxes)
        {
            if (status[initialBox] == 1)
                result += OpenBox(status, candies, keys, containedBoxes, initialBox);
            else
                status[initialBox] = 2;
        }

        return result;
    }

    public int OpenBox(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int currentBox)
    {
        if (candies[currentBox] == -1)
            return 0;

        var result = candies[currentBox];
        candies[currentBox] = -1;

        foreach (var containedBox in containedBoxes[currentBox])
        {
            if (status[containedBox] == 1)
                result += OpenBox(status, candies, keys, containedBoxes, containedBox);
            else
                status[containedBox] = 2;
        }

        foreach (var key in keys[currentBox])
        {
            if (status[key] == 2)
                result += OpenBox(status, candies, keys, containedBoxes, key);
            else
                status[key] = 1;
        }

        return result;
    }
}
