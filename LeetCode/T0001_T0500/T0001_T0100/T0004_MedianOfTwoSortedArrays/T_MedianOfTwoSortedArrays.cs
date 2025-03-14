namespace LeetCode.T0001_T0500.T0001_T0100.T0004_MedianOfTwoSortedArrays;

public class T_MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // если первый массив пустой - вернуть медиану второго
        if (nums1.Length == 0)
        {
            if (nums2.Length % 2 == 0)
                return (double)(nums2[nums2.Length / 2] + nums2[nums2.Length / 2 - 1]) / 2;
            else
                return nums2[nums2.Length / 2];
        }

        // если второй массив пустой - вернуть медиану первого
        if (nums2.Length == 0)
        {
            if (nums1.Length % 2 == 0)
                return (double)(nums1[nums1.Length / 2] + nums1[nums1.Length / 2 - 1]) / 2;
            else
                return nums1[nums1.Length / 2];
        }

        int m = Math.Min(nums1[0], nums2[0]);
        double l = m - 1, r = Math.Max(nums1[nums1.Length - 1], nums2[nums2.Length - 1]);
        double s = 0;
        int posNums1 = 0, posNums2 = 0, leftCount = 0, rightCount = 0;

        // бинпоиск по значению, которое поровну разобьёт массивы
        while (l + 1 < r)
        {
            s = (l + r) / 2;
            posNums1 = BinarySearch(nums1, s);
            posNums2 = BinarySearch(nums2, s);
            leftCount = posNums1 + posNums2 + 2;
            rightCount = nums1.Length + nums2.Length - leftCount;
            if (leftCount < rightCount)
                l = s;
            else if (leftCount >= rightCount)
                r = s;
        }

        posNums1 = BinarySearch(nums1, r);
        posNums2 = BinarySearch(nums2, r);
        leftCount = posNums1 + posNums2 + 2;
        rightCount = nums1.Length + nums2.Length - leftCount;

        if (posNums1 == -1)
        {
            if ((nums1.Length + nums2.Length) % 2 == 1)
                return nums2[posNums2];
            if (posNums2 < nums2.Length - 1 && nums1[0] < nums2[posNums2 + 1])
                return (double)(nums1[0] + nums2[posNums2]) / 2;
            if (posNums2 == nums2.Length - 1)
                return (double)(nums2[posNums2] + nums1[0]) / 2;
            return (double)(nums2[posNums2] + nums2[posNums2 + 1]) / 2;
        }

        if (posNums2 == -1)
        {
            if ((nums1.Length + nums2.Length) % 2 == 1)
                return nums1[posNums1];
            if (posNums1 < nums1.Length - 1 && nums2[0] < nums1[posNums1 + 1])
                return (double)(nums2[0] + nums1[posNums1]) / 2;
            if (posNums1 == nums1.Length - 1)
                return (double)(nums1[posNums1] + nums2[0]) / 2;
            return (double)(nums1[posNums1] + nums1[posNums1 + 1]) / 2;
        }

        double res = Math.Max(nums1[posNums1], nums2[posNums2]);
        // если нечётное - средний элемент
        if ((nums1.Length + nums2.Length) % 2 == 1)
            return res;
        // если чётное - среднее из двух центральных
        // если количество элементов слева после разбиения больше, оба значения надо брать слева
        if (leftCount > rightCount)
        {
            if (posNums1 > 0 && nums1[posNums1 - 1] > nums2[posNums2])
                return (double)(nums1[posNums1] + nums1[posNums1 - 1]) / 2;
            if (posNums2 > 0 && nums2[posNums2 - 1] > nums1[posNums1])
                return (double)(nums2[posNums2] + nums2[posNums2 - 1]) / 2;
            return (double)(nums1[posNums1] + nums2[posNums2]) / 2;
        }
        if (posNums1 == nums1.Length - 1)
            return (res + nums2[posNums2 + 1]) / 2;
        if (posNums2 == nums2.Length - 1)
            return (res + nums1[posNums1 + 1]) / 2;
        return (res + Math.Min(nums2[posNums2 + 1], nums1[posNums1 + 1])) / 2;
    }

    // бинпоиск позиции значения в массиве
    private int BinarySearch(int[] nums, double value)
    {
        int l = -1, r = nums.Length;
        int s;

        while (l + 1 < r)
        {
            s = (l + r) / 2;
            if (nums[s] <= value)
                l = s;
            else if (nums[s] > value)
                r = s;
        }

        return l;
    }
}
