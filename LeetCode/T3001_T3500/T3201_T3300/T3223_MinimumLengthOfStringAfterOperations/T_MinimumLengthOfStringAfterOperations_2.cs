namespace LeetCode.T3001_T3500.T3201_T3300.T3223_MinimumLengthOfStringAfterOperations;

public class T_MinimumLengthOfStringAfterOperations_2
{
    public int MinimumLength(string s)
    {
        var parity = (1 << 27) - 1;
        var sets = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var bits = 1 << s[i] - 'a';
            parity ^= bits;
            sets |= bits;
        }

        var result = 0;
        var lg = Math.Log2(sets) + 1;
        for (var i = 0; i < lg; i++)
        {
            var bits = 1 << i;
            if ((sets & bits) > 0)
                result += ((parity & bits) >> i) + 1;
        }

        return result;
    }
}
