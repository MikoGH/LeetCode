namespace LeetCode.T2501_T3000.T2601_T2700.T2683_NeighboringBitwiseXOR;

public class T_NeighboringBitwiseXOR
{
    public bool DoesValidArrayExist(int[] derived)
    {
        var original = new int[derived.Length + 1];
        original[0] = 0;
        for (int i = 0; i < derived.Length; i++)
        {
            original[i + 1] = derived[i] ^ original[i];
        }

        var isZero = original[0] == original[^1];

        original[0] = 1;
        for (int i = 0; i < derived.Length; i++)
        {
            original[i + 1] = derived[i] ^ original[i];
        }

        var isOne = original[0] == original[^1];

        return isZero || isOne;
    }
}
