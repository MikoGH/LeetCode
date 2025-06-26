using LeetCode.T2001_T2500.T2001_T2100.T2040_KthSmallestProductOfTwoSortedArrays;

namespace LeetCode.Tests.T2001_T2500;

public class T2040_KthSmallestProductOfTwoSortedArrays_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_KthSmallestProductOfTwoSortedArrays();

        var nums1 = new int[] { -4, -2, 0, 3 };
        var nums2 = new int[] { 2, 4 };

        var k = 6;

        var result = taskClass.KthSmallestProduct(nums1, nums2, k);

        var expected = 0;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_KthSmallestProductOfTwoSortedArrays();

        var nums1 = new int[] { -9, 6, 10 };
        var nums2 = new int[] { -7, -1, 1, 2, 3, 4, 4, 6, 9, 10 };

        var k = 15;

        var result = taskClass.KthSmallestProduct(nums1, nums2, k);

        var expected = 10;

        Assert.Equal(expected, result);
    }
}
