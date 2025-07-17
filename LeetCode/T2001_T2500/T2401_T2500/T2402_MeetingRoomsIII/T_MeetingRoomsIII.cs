namespace LeetCode.T2001_T2500.T2401_T2500.T2402_MeetingRoomsIII;

public class T_MeetingRoomsIII
{
    public int MostBooked(int n, int[][] meetings)
    {
        var availableRoomsQueue = new PriorityQueue<(long StartTime, int Room), int>();
        var busyRoomsQueue = new PriorityQueue<(long EndTime, int Room), long>();

        for (int i = 0; i < n; i++)
            availableRoomsQueue.Enqueue((0, i), i);

        Array.Sort(meetings, (a, b) => a[0] - b[0]);

        var rooms = new int[n];

        long lastTime = -1;
        foreach (var meeting in meetings)
        {
            while (busyRoomsQueue.Count > 0 && (meeting[0] >= busyRoomsQueue.Peek().EndTime || lastTime == busyRoomsQueue.Peek().EndTime) || availableRoomsQueue.Count == 0)
            {
                var busyRoom = busyRoomsQueue.Dequeue();
                availableRoomsQueue.Enqueue((busyRoom.EndTime, busyRoom.Room), busyRoom.Room);
                lastTime = busyRoom.EndTime;
            }

            var availableRoom = availableRoomsQueue.Dequeue();
            rooms[availableRoom.Room]++;
            var endTime = availableRoom.StartTime > meeting[0] ? availableRoom.StartTime + (meeting[1] - meeting[0]) : meeting[1];
            busyRoomsQueue.Enqueue((endTime, availableRoom.Room), endTime);
        }

        var maxValue = 0;
        var roomWithMaxValue = 0;
        for (int i = 0; i < n; i++)
        {
            if (rooms[i] > maxValue)
            {
                maxValue = rooms[i];
                roomWithMaxValue = i;
            }
        }

        return roomWithMaxValue;
    }
}
