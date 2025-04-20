namespace LeetCode.T0501_T1000.T0701_T0800.T0781_RabbitsInForest;

public class T_RabbitsInForest
{
    public int NumRabbits(int[] answers)
    {
        var counts = new int[1001];

        for (int i = 0; i < answers.Length; i++)
        {
            counts[answers[i]]++;
        }

        var result = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            result += (int)Math.Ceiling((double)counts[i] / (i + 1)) * (i + 1);
        }

        return result;
    }
}
