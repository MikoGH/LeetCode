namespace LeetCode.T3001_T3500.T3401_T3500.T3440_RescheduleMeetingsForMaximumFreeTimeII;

public class T_RescheduleMeetingsForMaximumFreeTimeII
{
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        var n = startTime.Length;
        var spaces = new int[n + 1];
        spaces[0] = startTime[0];
        for (int i = 1; i < n; i++)
        {
            spaces[i] = startTime[i] - endTime[i - 1];
        }
        spaces[^1] = eventTime - endTime[^1];

        Array.Sort(spaces);

        var maxFreeTime = 0;

        for (int i = 0; i < n; i++)
        {
            var nextTime = (i + 1 < n ? startTime[i + 1] : eventTime);
            var prevTime = (i - 1 >= 0 ? endTime[i - 1] : 0);

            var leftSpace = startTime[i] - prevTime;
            var rightSpace = nextTime - endTime[i];

            var curTime = endTime[i] - startTime[i];

            var freeTime = nextTime - prevTime;

            if (leftSpace == rightSpace && leftSpace == spaces[^1] && leftSpace == spaces[^2] && curTime > spaces[^3]
                || leftSpace == spaces[^1] && rightSpace == spaces[^2] && curTime > spaces[^3]
                || leftSpace == spaces[^2] && rightSpace == spaces[^1] && curTime > spaces[^3]
                || leftSpace == spaces[^1] && curTime > spaces[^2]
                || rightSpace == spaces[^1] && curTime > spaces[^2]
                || curTime > spaces[^1])
            {
                freeTime -= curTime;
            }

            if (freeTime > maxFreeTime)
                maxFreeTime = freeTime;
        }

        return maxFreeTime;
    }
}
