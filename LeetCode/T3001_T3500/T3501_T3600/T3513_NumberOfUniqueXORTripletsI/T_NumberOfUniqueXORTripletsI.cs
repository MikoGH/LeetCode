namespace LeetCode.T3001_T3500.T3501_T3600.T3513_NumberOfUniqueXORTripletsI;

public class T_NumberOfUniqueXORTripletsI
{
    public int UniqueXorTriplets(int[] nums)
    {
        if (nums.Length == 1)
            return 1;
        if (nums.Length == 2)
            return 2;
        return (int)Math.Pow(2, (int)Math.Log2(nums.Length) + 1);
    }
}
