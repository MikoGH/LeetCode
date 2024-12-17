namespace LeetCode.T1501_T2000.T1792_MaximumAveragePassRatio;

public class T_MaximumAveragePassRatio
{
    public double MaxAverageRatio(int[][] classes, int extraStudents)
    {
        var queue = new PriorityQueue<int[], double>(classes.Length);

        for (int i = 0; i < classes.Length; i++)
        {
            queue.Enqueue(classes[i], (double)classes[i][0] / classes[i][1] - (double)(classes[i][0] + 1) / (classes[i][1] + 1));
        }

        for (int i = 0; i < extraStudents; i++)
        {
            var element = queue.Dequeue();
            element[0] += 1;
            element[1] += 1;
            queue.Enqueue(element, (double)element[0] / element[1] - (double)(element[0] + 1) / (element[1] + 1));
        }

        double result = 0;
        while (queue.Count > 0)
        {
            var element = queue.Dequeue();
            result += (double)element[0] / element[1];
        }

        return result / classes.Length;
    }
}
