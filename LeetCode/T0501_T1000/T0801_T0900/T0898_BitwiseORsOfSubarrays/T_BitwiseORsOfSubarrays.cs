namespace LeetCode.T0501_T1000.T0801_T0900.T0898_BitwiseORsOfSubarrays;

public class T_BitwiseORsOfSubarrays
{
    public int SubarrayBitwiseORs(int[] arr)
    {
        var values = new HashSet<int>();
        var prevValues = new HashSet<int>();

        foreach (var elm in arr)
        {
            var newValues = new HashSet<int>();
            foreach (var elm2 in prevValues)
            {
                newValues.Add(elm | elm2);
            }
            prevValues = newValues;
            prevValues.Add(elm);
            foreach (var elm2 in prevValues)
            {
                values.Add(elm2);
            }
        }

        return values.Count;
    }
}
