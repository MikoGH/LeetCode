namespace LeetCode.T2501_T3000.T2801_T2900.T2818_ApplyOperationsToMaximizeScore;

public class T_ApplyOperationsToMaximizeScore_2
{
    const int Mod = 1_000_000_007;

    public int MaximumScore(IList<int> nums, int k)
    {
        var primeScores = new int[nums.Max() + 1];
        for (int i = 2; i < primeScores.Length; i++)
        {
            if (primeScores[i] > 0)
                continue;

            for (int j = i; j < primeScores.Length; j += i)
            {
                primeScores[j]++;
            }
        }

        var numsPrimeScores = new int[nums.Count];
        for (int i = 0; i < nums.Count; i++)
        {
            numsPrimeScores[i] = primeScores[nums[i]];
        }

        var nextDominant = new int[nums.Count];
        var prevDominant = new int[nums.Count];
        Array.Fill(nextDominant, nums.Count);
        Array.Fill(prevDominant, -1);

        var decreasingPrimeScoreStack = new Stack<int>();
        for (int i = 0; i < nums.Count; i++)
        {
            while (decreasingPrimeScoreStack.Count > 0 && numsPrimeScores[decreasingPrimeScoreStack.Peek()] < numsPrimeScores[i])
            {
                int topIndex = decreasingPrimeScoreStack.Pop();
                nextDominant[topIndex] = i;
            }

            if (decreasingPrimeScoreStack.Count > 0)
                prevDominant[i] = decreasingPrimeScoreStack.Peek();

            decreasingPrimeScoreStack.Push(i);
        }

        var numOfSubarrays = new long[nums.Count];
        for (int i = 0; i < nums.Count; i++)
        {
            numOfSubarrays[i] = ((long)nextDominant[i] - (long)i) * ((long)i - (long)prevDominant[i]);
        }

        var processingQueue = new PriorityQueue<int, (int, int)>();

        for (int i = 0; i < nums.Count; i++)
        {
            processingQueue.Enqueue(i, (-nums[i], i));
        }

        long score = 1;

        while (k > 0)
        {
            var index = processingQueue.Dequeue();
            var num = nums[index];

            long operations = Math.Min((long)k, numOfSubarrays[index]);

            score = (score * GetPow(num, operations)) % Mod;

            k -= (int)operations;
        }

        return (int)score;
    }

    private long GetPow(long x, long pow)
    {
        long result = 1;

        while (pow > 0)
        {
            if (pow % 2 == 1)
                result = (result * x) % Mod;
            x = (x * x) % Mod;
            pow >>= 1;
        }

        return result;
    }
}
