namespace LeetCode.T0001_T0500.T0301_T0400.T0307_RangeSumQueryMutable;

public class T_RangeSumQueryMutable
{
    public class NumArray
    {
        int _size;
        int[] _tree;

        public NumArray(int[] nums)
        {
            _size = 1 << (int)Math.Ceiling(Math.Log2(nums.Length));
            _tree = new int[_size * 2 - 1];

            for (int i = 0; i < nums.Length; i++)
            {
                Update(i, nums[i]);
            }
        }

        public void Update(int index, int val)
        {
            Update(index, val, 0, _size, 0);
        }

        private void Update(int index, int val, int treeLeft, int treeRight, int treeIndex)
        {
            if (treeLeft + 1 >= treeRight)
            {
                _tree[treeIndex] = val;
                return;
            }

            var s = treeLeft + treeRight >> 1;

            if (index < s)
            {
                Update(index, val, treeLeft, s, treeIndex * 2 + 1);
            }
            else
            {
                Update(index, val, s, treeRight, treeIndex * 2 + 2);
            }

            _tree[treeIndex] = _tree[treeIndex * 2 + 1] + _tree[treeIndex * 2 + 2];
        }

        public int SumRange(int left, int right)
        {
            return SumRange(left, right + 1, 0, _size, 0);
        }

        private int SumRange(int left, int right, int treeLeft, int treeRight, int treeIndex)
        {
            if (treeLeft >= left && treeRight <= right)
                return _tree[treeIndex];

            if (treeRight <= left || treeLeft >= right)
                return 0;

            var s = treeLeft + treeRight >> 1;
            return SumRange(left, right, treeLeft, s, treeIndex * 2 + 1) + SumRange(left, right, s, treeRight, treeIndex * 2 + 2);
        }
    }
}
