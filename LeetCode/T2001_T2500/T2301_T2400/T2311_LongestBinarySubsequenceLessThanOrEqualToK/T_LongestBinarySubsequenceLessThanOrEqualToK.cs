namespace LeetCode.T2001_T2500.T2301_T2400.T2311_LongestBinarySubsequenceLessThanOrEqualToK;

public class T_LongestBinarySubsequenceLessThanOrEqualToK
{
    public int LongestSubsequence(string s, int k)
    {
        long result = 0;
        var savedPos = new List<int>();
        var len = 0;
        var deleted = 0;

        for (int i = 0; i < s.Length; i++)
        {
            len++;
            result <<= 1;
            if (s[i] == '1')
            {
                result++;
                savedPos.Add(i);
            }

            while (result > k)
            {
                result -= (1 << (len - (savedPos[deleted] - deleted) - 1));
                len--;
                deleted++;
            }
        }

        return len;
    }
}

//var count0 = 0;
//var longestLen = 0;
//var num = 0;
//for (int i = 0; i < s.Length; i++)
//{
//    int j = i;
//    while (num <= k && j < s.Length)
//    {
//        num <<= 1;
//        if (s[j] == '1')
//            num++;
//        j++;
//    }

//    var len = j - i;
//    if (len - 1 + count0 > longestLen)
//        longestLen = len - 1 + count0;

//    if (s[i] == '1')
//        num /= 1 << len;
//    else
//        count0++;
//}

//return longestLen;
