namespace LeetCode.T2501_T3000.T2601_PrimeSubtractionOperation;

public class T_PrimeSubtractionOperation
{
    private List<int> _primes = new List<int>();

    public bool PrimeSubOperation(int[] nums)
    {
        bool[] numbers = new bool[1010];
        numbers[0] = true;
        numbers[1] = true;

        for (int step = 2; step < numbers.Length; step++)
        {
            for (int i = step * 2; i < numbers.Length; i += step)
            {
                numbers[i] = true;
            }
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            if (!numbers[i])
                _primes.Add(i);
        }

        var prime = PrimeBinarySearch(0, nums[0]);
        if (nums[0] - prime > 0)
            nums[0] -= prime;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1])
                return false;

            prime = PrimeBinarySearch(nums[i - 1], nums[i]);
            if (nums[i] - prime > nums[i - 1])
                nums[i] -= prime;
        }

        return true;
    }

    private int PrimeBinarySearch(int num1, int num2)
    {
        var difference = num2 - num1;
        int l = 0, r = _primes.Count - 1;
        while (l + 1 < r)
        {
            int s = (l + r) / 2;
            if (_primes[s] < difference)
                l = s;
            else
                r = s;
        }

        return _primes[l];
    }
}
