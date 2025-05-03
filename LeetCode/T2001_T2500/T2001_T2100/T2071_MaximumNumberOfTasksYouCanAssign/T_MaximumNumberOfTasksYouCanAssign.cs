namespace LeetCode.T2001_T2500.T2001_T2100.T2071_MaximumNumberOfTasksYouCanAssign;

public class T_MaximumNumberOfTasksYouCanAssign
{
    private record struct Worker(int Strength, bool UsedPill);

    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    {
        Array.Sort(tasks);

        var queue = new PriorityQueue<Worker, double>();
        foreach (var workerStrength in workers)
        {
            queue.Enqueue(new Worker(workerStrength, false), workerStrength);
        }

        var result = 0;
        foreach (var task in tasks)
        {
            if (queue.Count == 0)
                break;

            var worker = queue.Dequeue();
            var exit = false;
            while (worker.Strength < task || pills == 0 && worker.UsedPill)
            {
                if (!worker.UsedPill)
                {
                    var workerWithPill = new Worker(worker.Strength + strength, true);
                    queue.Enqueue(workerWithPill, workerWithPill.Strength + 0.5);
                }
                if (queue.Count == 0)
                {
                    exit = true;
                    break;
                }
                worker = queue.Dequeue();
            }
            if (exit)
                break;

            if (worker.UsedPill)
                pills--;
            result++;
        }

        return result;
    }
}
