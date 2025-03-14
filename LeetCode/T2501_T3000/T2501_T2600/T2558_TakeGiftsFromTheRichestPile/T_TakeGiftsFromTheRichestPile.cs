namespace LeetCode.T2501_T3000.T2501_T2600.T2558_TakeGiftsFromTheRichestPile;

public class T_TakeGiftsFromTheRichestPile
{
    public long PickGifts(int[] gifts, int k)
    {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
        for (int i = 0; i < gifts.Length; i++)
        {
            queue.Enqueue(gifts[i], gifts[i]);
        }

        for (int i = 0; i < k; i++)
        {
            var maxElm = queue.Dequeue();
            maxElm = (int)Math.Sqrt(maxElm);
            queue.Enqueue(maxElm, maxElm);
        }

        long sum = 0;
        while (queue.Count > 0)
        {
            sum += queue.Dequeue();
        }

        return sum;
    }
}
