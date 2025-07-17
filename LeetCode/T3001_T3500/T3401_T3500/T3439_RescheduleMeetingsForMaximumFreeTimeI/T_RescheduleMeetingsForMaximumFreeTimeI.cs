namespace LeetCode.T3001_T3500.T3401_T3500.T3439_RescheduleMeetingsForMaximumFreeTimeI;

public class T_RescheduleMeetingsForMaximumFreeTimeI
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        var sumDuration = 0;
        var maxFreeTime = 0;
        var prevEventEnd = 0;

        for (int endPos = 0; endPos < endTime.Length; endPos++)
        {
            sumDuration += endTime[endPos] - startTime[endPos];

            if (endPos + 1 < k)
                continue;

            var nextEventStart = endPos + 1 < endTime.Length ? startTime[endPos + 1] : eventTime;
            var freeTime = nextEventStart - prevEventEnd - sumDuration;
            if (freeTime > maxFreeTime)
                maxFreeTime = freeTime;

            sumDuration -= (endTime[endPos - k + 1] - startTime[endPos - k + 1]);
            prevEventEnd = endTime[endPos - k + 1];
        }

        return maxFreeTime;
    }
}
