namespace LeetCode.T0001_T0500.T0301_T0400.T0307_RangeSumQueryMutable;

public class T_RangeSumQueryMutable2
{
    public class NumArray
    {
        int[] _nums;
        int[] _fenvic;

        public NumArray(int[] nums)
        {
            _nums = new int[nums.Length];
            _fenvic = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                Update(i, nums[i]);
            }
        }

        public void Update(int index, int val)
        {
            var diff = val - _nums[index];
            _nums[index] = val;

            while (index < _fenvic.Length)
            {
                _fenvic[index] += diff;
                index = index | index + 1;
            }
        }

        public int SumRange(int left, int right)
        {
            return GetSum(right) - GetSum(left - 1);
        }

        private int GetSum(int index)
        {
            var sum = 0;

            while (index >= 0)
            {
                sum += _fenvic[index];
                index = (index & index + 1) - 1;
            }

            return sum;
        }
    }
}
