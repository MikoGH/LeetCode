namespace LeetCode.T1501_T2000.T1980_FindUniqueBinaryString;

public class T_FindUniqueBinaryString
{
    public string FindDifferentBinaryString(string[] nums)
    {
        var used = new bool[33];

        var numLength = Math.Min(nums.Length, 5);
        for (int i = 0; i < nums.Length; i++)
        {
            var num = 0;
            for (int j = 1; j <= numLength; j++)
            {
                if (nums[i][^j] == '1')
                    num += 1 << (j - 1);
            }
            used[num] = true;
        }

        for (int i = 0; i < used.Length; i++)
        {
            if (!used[i])
            {
                var num = i;
                var result = new char[nums.Length];
                Array.Fill(result, '0');
                for (int j = 1; j <= numLength; j++)
                {
                    if (num % 2 == 1)
                        result[^j] = '1';
                    num >>= 1;
                }

                return new string(result);
            }
        }

        return "";
    }
}
