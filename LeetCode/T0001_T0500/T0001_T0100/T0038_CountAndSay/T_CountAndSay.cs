using System.Text;

namespace LeetCode.T0001_T0500.T0001_T0100.T0038_CountAndSay;

public class T_CountAndSay
{
    public string CountAndSay(int n)
    {
        var prev = "1";
        for (int _ = 0; _ < n - 1; _++)
        {
            var sb = new StringBuilder();
            var smb = prev[0];
            var count = 0;
            for (int i = 0; i < prev.Length; i++)
            {
                if (prev[i] == smb)
                    count++;

                if (i == prev.Length - 1 || prev[i + 1] != smb)
                {
                    sb.Append(count);
                    sb.Append(smb);
                    if (i + 1 < prev.Length)
                    {
                        smb = prev[i + 1];
                        count = 0;
                    }
                }
            }
            prev = sb.ToString();
        }

        return prev;
    }
}
