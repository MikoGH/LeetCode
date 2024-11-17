namespace LeetCode.T0001_T0500.T0042_TrappingRainWater;

public class T_TrappingRainWater
{
    public int Trap(int[] height)
    {
        var maxPos = 0;

        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] >= height[maxPos])
                maxPos = i;
        }

        var water = 0;
        var max = 0;
        for (int i = 0; i < maxPos; i++)
        {
            if (height[i] >= max)
                max = height[i];

            water += max - height[i];
        }

        max = 0;
        for (int i = height.Length - 1; i > maxPos; i--)
        {
            if (height[i] >= max)
                max = height[i];

            water += max - height[i];
        }

        return water;
    }
}
