namespace LeetCode.T2001_T2500.T2101_T2200.T2179_CountGoodTripletsInAnArray;

public class T_CountGoodTripletsInAnArray
{
    int[] _fenvic;

    public long GoodTriplets(int[] nums1, int[] nums2)
    {
        var len = nums1.Length;
        var pos2 = new int[len];
        for (int i = 0; i < len; i++)
        {
            pos2[nums2[i]] = i;
        }

        var mappings = new int[len];
        for (int i = 0; i < mappings.Length; i++)
        {
            mappings[pos2[nums1[i]]] = i;
        }

        _fenvic = new int[len + 1];
        long result = 0;

        for (int i = 0; i < len; i++)
        {
            var pos = mappings[i];
            long leftCount = GetSum(pos);
            long rightCount = len - pos - 1 - (i - leftCount);
            Update(pos, 1);
            result += leftCount * rightCount;
        }

        return result;
    }

    public void Update(int index, int diff)
    {
        while (index < _fenvic.Length)
        {
            _fenvic[index] += diff;
            index = index | (index + 1);
        }
    }

    private int GetSum(int index)
    {
        var sum = 0;
        while (index >= 0)
        {
            sum += _fenvic[index];
            index = (index & (index + 1)) - 1;
        }
        return sum;
    }
}
