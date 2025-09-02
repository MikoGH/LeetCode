namespace LeetCode.T3001_T3500.T3401_T3500.T3477_FruitsIntoBasketsII;

public class T_FruitsIntoBasketsII
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var used = new bool[baskets.Length];
        var count = 0;

        for (int i = 0; i < fruits.Length; i++)
        {
            var placed = false;
            for (int j = 0; j < baskets.Length; j++)
            {
                if (!used[j] && baskets[j] >= fruits[i])
                {
                    used[j] = true;
                    placed = true;
                    break;
                }
            }
            if (!placed)
                count++;
        }

        return count;
    }
}
