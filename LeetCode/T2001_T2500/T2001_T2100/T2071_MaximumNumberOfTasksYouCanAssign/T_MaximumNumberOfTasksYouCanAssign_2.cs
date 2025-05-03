namespace LeetCode.T2001_T2500.T2001_T2100.T2071_MaximumNumberOfTasksYouCanAssign;

public class T_MaximumNumberOfTasksYouCanAssign_2
{
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    {
        Array.Sort(tasks, (a, b) => b.CompareTo(a));
        Array.Sort(workers, (a, b) => b.CompareTo(a));

        int taskIndex = 0;
        int workerIndex = 0;
        int pillWorkerPointer = 0;
        int result = 0;
        bool scanningDown = true;

        var pillQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        while (taskIndex < tasks.Length)
        {
            while (workerIndex < workers.Length && workers[workerIndex] == -1)
                workerIndex++;

            if (workerIndex >= workers.Length)
            {
                if (pillQueue.Count > 0 && pillQueue.Peek() >= tasks[taskIndex])
                {
                    pillQueue.Dequeue();
                    result++;
                }
            }
            else if (workers[workerIndex] >= tasks[taskIndex])
            {
                workers[workerIndex] = -1;
                workerIndex++;
                result++;
            }
            else
            {
                if (scanningDown)
                {
                    while (pillWorkerPointer < workers.Length &&
                           (workers[pillWorkerPointer] == -1 || workers[pillWorkerPointer] + strength >= tasks[taskIndex]))
                    {
                        pillWorkerPointer++;
                    }

                    if (pillWorkerPointer == workers.Length)
                    {
                        scanningDown = false;
                        pillWorkerPointer = workers.Length - 1;
                    }
                }

                while (pillWorkerPointer >= workers.Length ||
                      (pillWorkerPointer > workerIndex &&
                      (workers[pillWorkerPointer] == -1 || workers[pillWorkerPointer] + strength < tasks[taskIndex])))
                {
                    pillWorkerPointer--;
                }

                if (pillQueue.Count >= pills && pillQueue.Count > 0 && pillQueue.Peek() >= tasks[taskIndex])
                {
                    pillQueue.Dequeue();
                    result++;
                }
                else if (pillWorkerPointer >= 0 && workers[pillWorkerPointer] + strength >= tasks[taskIndex])
                {
                    pillQueue.Enqueue(workers[pillWorkerPointer], workers[pillWorkerPointer]);
                    workers[pillWorkerPointer] = -1;
                    pillWorkerPointer = scanningDown ? pillWorkerPointer - 1 : pillWorkerPointer + 1;
                }
                else if (pillQueue.Count > 0 && pillQueue.Peek() >= tasks[taskIndex])
                {
                    pillQueue.Dequeue();
                    result++;
                }
            }

            taskIndex++;
            pillWorkerPointer = Math.Max(pillWorkerPointer, workerIndex);
        }

        return result + Math.Min(pillQueue.Count, pills);
    }
    //public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    //{
    //    Array.Sort(tasks);
    //    Array.Sort(workers);

    //    var l = 1;
    //    var r = Math.Min(tasks.Length, workers.Length);

    //    while (l + 1 < r)
    //    {
    //        var s = (l + r) >> 1;
    //        if (Check(tasks, workers, pills, strength, s))
    //        {
    //            l = s;
    //        }
    //        else
    //        {
    //            r = s;
    //        }
    //    }

    //    return l;
    //}

    //private bool Check(int[] tasks, int[] workers, int pills, int strength, int s)
    //{
    //    var sortedDct = new SortedDictionary<int, int>();
    //    for (int i = workers.Length - s; i < workers.Length; i++)
    //    {
    //        if (sortedDct.ContainsKey(workers[i]))
    //            sortedDct[workers[i]]++;
    //        else
    //            sortedDct.Add(workers[i], 1);
    //    }
    //    for (int i = s - 1; i >= 0; i--)
    //    {
    //        int key = sortedDct.Last().Key;
    //        if (key >= tasks[i])
    //        {
    //            sortedDct[key]--;
    //            if (sortedDct[key] == 0)
    //                sortedDct.Remove(key);
    //        }
    //        else
    //        {
    //            if (pills == 0)
    //                return false;
    //            key = GetCeilingKey(sortedDct, tasks[i] - strength);
    //            if (key == -1)
    //                return false;
    //            sortedDct[key]--;
    //            if (sortedDct[key] == 0)
    //                sortedDct.Remove(key);
    //            pills--;
    //        }
    //    }

    //    return true;
    //}

    //private int GetCeilingKey(SortedDictionary<int, int> sortedDct, int target)
    //{
    //    var keys = sortedDct.Keys.ToList();
    //    int left = 0;
    //    int right = sortedDct.Count - 1;
    //    int result = -1;

    //    while (left + 1 < right)
    //    {
    //        int midIdx = (right - left) >> 1;
    //        if (keys[midIdx] >= target)
    //        {
    //            result = midIdx;
    //            right = midIdx;
    //        }
    //        else
    //        {
    //            left = midIdx;
    //        }
    //    }
    //    return result;
    //}
}
