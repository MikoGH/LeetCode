namespace LeetCode.T3001_T3500.T3401_T3500.T3479_FruitsIntoBasketsIII;

public class T_FruitsIntoBasketsIII
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        int n = baskets.Length;
        int blockSize = (int)Math.Sqrt(n);
        int blocks = (n + blockSize - 1) / blockSize;
        int[] maxByBlocks = new int[blocks];

        int result = 0;

        for (int i = 0; i < n; i++)
        {
            if (baskets[i] > maxByBlocks[i / blockSize])
                maxByBlocks[i / blockSize] = baskets[i];
        }

        foreach (int fruit in fruits)
        {
            bool placed = false;
            for (int block = 0; block < blocks; block++)
            {
                if (maxByBlocks[block] < fruit)
                    continue;

                maxByBlocks[block] = 0;
                for (int i = 0; i < blockSize; i++)
                {
                    int pos = block * blockSize + i;
                    if (pos > n)
                        break;
                    if (baskets[pos] >= fruit && !placed)
                    {
                        baskets[pos] = 0;
                        placed = true;
                    }

                    if (baskets[pos] > maxByBlocks[block])
                        maxByBlocks[block] = baskets[pos];
                }
                break;
            }
            if (!placed)
                result++;
        }
        return result;
    }
}
