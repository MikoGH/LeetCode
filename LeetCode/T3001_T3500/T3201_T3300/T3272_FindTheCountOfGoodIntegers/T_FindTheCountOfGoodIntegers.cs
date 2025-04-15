namespace LeetCode.T3001_T3500.T3201_T3300.T3272_FindTheCountOfGoodIntegers;

public class T_FindTheCountOfGoodIntegers
{
    public long CountGoodIntegers(int n, int k)
    {
        var goodCombinations = new HashSet<string>();

        var start = (int)Math.Pow(10, (n - 1) >> 1);
        var end = start * 10;
        int skip = n & 1;
        for (int i = start; i < end; i++)
        {
            var s = i.ToString();
            var reversedS = new string(s.Reverse().Skip(skip).ToArray());
            var palindrome = s + reversedS;
            var numericPalindrome = long.Parse(palindrome);
            if (numericPalindrome % k == 0)
            {
                var sortedCombination = numericPalindrome.ToString().ToCharArray();
                Array.Sort(sortedCombination);
                var stringSortedCombination = new string(sortedCombination);
                goodCombinations.Add(stringSortedCombination);
            }
        }

        var factorials = new long[n + 1];
        factorials[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            factorials[i] = i * factorials[i - 1];
        }

        long result = 0;
        foreach (var combination in goodCombinations)
        {
            var counts = new int[10];
            for (int i = 0; i < n; i++)
            {
                counts[combination[i] - '0']++;
            }

            long permutations = (n - counts[0]) * factorials[n - 1];
            for (int i = 0; i < 10; i++)
            {
                permutations /= factorials[counts[i]];
            }

            result += permutations;
        }

        return result;
    }
}
