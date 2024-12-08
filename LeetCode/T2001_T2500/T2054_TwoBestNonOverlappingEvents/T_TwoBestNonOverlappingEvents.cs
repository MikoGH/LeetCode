namespace LeetCode.T2001_T2500.T2054_TwoBestNonOverlappingEvents;

public class T_TwoBestNonOverlappingEvents
{
    public int MaxTwoEvents(int[][] events)
    {
        var eventsByStart = events;
        var eventsByEnd = (int[][])events.Clone();
        Array.Sort(eventsByStart, (x, y) => x[0] - y[0]);
        Array.Sort(eventsByEnd, (x, y) => x[1] - y[1]);

        var result = 0;
        var maxPrev = 0;
        var iMaxPrev = 0;

        int i = 0, j = 0;
        while (i < eventsByEnd.Length || j < eventsByStart.Length)
        {
            if (j < eventsByStart.Length && eventsByStart[j][0] > eventsByEnd[iMaxPrev][1] && maxPrev + eventsByStart[j][2] > result)
                result = maxPrev + eventsByStart[j][2];

            if (j < eventsByStart.Length && eventsByStart[j][0] <= eventsByEnd[i][1])
            {
                j++;
                continue;
            }

            if (eventsByEnd[i][2] > maxPrev)
            {
                maxPrev = eventsByEnd[i][2];
                iMaxPrev = i;
            }

            i++;
        }

        if (maxPrev > result)
            result = maxPrev;

        return result;
    }
}
