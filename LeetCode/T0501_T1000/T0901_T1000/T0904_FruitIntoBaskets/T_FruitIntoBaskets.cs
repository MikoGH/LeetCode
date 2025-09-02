namespace LeetCode.T0501_T1000.T0901_T1000.T0904_FruitIntoBaskets;

public class T_FruitIntoBaskets
{
    public int TotalFruit(int[] fruits)
    {
        if (fruits.Length <= 2)
            return fruits.Length;

        var type1 = -1;
        var type2 = -1;

        var last1 = -1;
        var last2 = -1;

        var result = 2;
        var count = 0;

        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] == type1)
            {
                last1 = i;
                count++;
                if (count > result)
                    result = count;
                continue;
            }
            if (fruits[i] == type2)
            {
                last2 = i;
                count++;
                if (count > result)
                    result = count;
                continue;
            }
            if (last1 <= last2)
            {
                count = i - last1;
                if (count > result)
                    result = count;
                last1 = i;
                type1 = fruits[i];
                continue;
            }
            count = i - last2;
            if (count > result)
                result = count;
            last2 = i;
            type2 = fruits[i];
            continue;
        }

        return result;
    }
}
