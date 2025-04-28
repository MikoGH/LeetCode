namespace LeetCode.T2001_T2500.T2101_T2200.T2145_CountTheHiddenSequences;

public class T_CountTheHiddenSequences
{
    public int NumberOfArrays(int[] differences, int lower, int upper)
    {
        var difference = upper - lower;

        var min = 0;
        var max = 0;

        var sum = 0;
        for (var i = 0; i < differences.Length; i++)
        {
            sum += differences[i];
            if (sum > max)
                max = sum;
            if (sum < min)
                min = sum;

            if (difference - (max - min) + 1 < 0)
                return 0;
        }

        var result = difference - (max - min) + 1;

        return result;
    }
}
