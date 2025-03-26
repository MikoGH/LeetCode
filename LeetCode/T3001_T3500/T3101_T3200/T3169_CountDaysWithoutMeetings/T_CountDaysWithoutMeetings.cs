using System.Linq;

namespace LeetCode.T3001_T3500.T3101_T3200.T3169_CountDaysWithoutMeetings;

public class T_CountDaysWithoutMeetings
{
    public int CountDays(int days, int[][] meetings)
    {
        var meetingsByDays = new Dictionary<int, int>();

        foreach (var meeting in meetings)
        {
            if (meetingsByDays.ContainsKey(meeting[0]))
                meetingsByDays[meeting[0]]++;
            else
                meetingsByDays[meeting[0]] = 1;

            if (meetingsByDays.ContainsKey(meeting[1] + 1))
                meetingsByDays[meeting[1] + 1]--;
            else
                meetingsByDays[meeting[1] + 1] = -1;
        }

        if (!meetingsByDays.ContainsKey(days + 1))
            meetingsByDays[days + 1] = 0;

        var freeDays = 0;
        var countMeetings = 0;

        var orderedDays = meetingsByDays.Keys.OrderBy(k => k).ToList();

        freeDays += orderedDays[0] - 1;

        for (int i = 0; i < orderedDays.Count - 1; i++)
        {
            countMeetings += meetingsByDays[orderedDays[i]];

            if (countMeetings == 0)
                freeDays += orderedDays[i + 1] - orderedDays[i];
        }

        return freeDays;
    }
}
