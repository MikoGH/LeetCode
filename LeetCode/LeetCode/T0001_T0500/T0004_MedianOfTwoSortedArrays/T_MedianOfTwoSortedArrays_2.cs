namespace LeetCode.T0001_T0500.T0004_MedianOfTwoSortedArrays;

public class T_MedianOfTwoSortedArrays_2
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // если первый массив пустой - вернуть медиану второго
        if (nums1.Length == 0)
            return GetMedianOfSortedArray(nums2);
        // если второй массив пустой - вернуть медиану первого
        if (nums2.Length == 0)
            return GetMedianOfSortedArray(nums1);

        // поиск значения сепаратора, которое (почти)поровну разобьёт массивы
        var separator = SeparatorBinarySearch(nums1, nums2);

        // поиск позиции со значением меньше сепаратора в обоих массивах
        var posNums1 = BinarySearch(nums1, separator);
        var posNums2 = BinarySearch(nums2, separator);
        // подсчёт суммарного количества элементов в двух массивах слева и справа от сепаратора
        var leftCount = posNums1 + posNums2 + 2;
        var rightCount = nums1.Length + nums2.Length - leftCount;

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

    // бинпоиск по значению, которое (почти)поровну разобьёт массивы
    private double SeparatorBinarySearch(int[] nums1, int[] nums2)
    {
        double l = Math.Min(nums1[0], nums2[0]) - 1, r = Math.Max(nums1[nums1.Length - 1], nums2[nums2.Length - 1]);
        double s = 0;
        int posNums1 = 0, posNums2 = 0, leftCount = 0, rightCount = 0;

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

        return r;
    }

    // возвращает медиану массива
    private double GetMedianOfSortedArray(int[] nums)
    {
        if (nums.Length % 2 == 0)
            return (double)(nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2;
        else
            return nums[nums.Length / 2];
    }

}
