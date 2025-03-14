using LeetCode.T0001_T0500.T0001_T0100.T0004_MedianOfTwoSortedArrays;

namespace LeetCode.Tests.T0001_T0500;

public class T0004_MedianOfTwoSortedArrays_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[5] { 1, 2, 4, 8, 12 };
        var nums2 = new int[5] { 1, 2, 4, 8, 12 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 4;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[5] { 1, 2, 4, 8, 12 };
        var nums2 = new int[5] { 1, 2, 9, 9, 12 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 6;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[7] { 1, 5, 7, 8, 9, 15, 24 };
        var nums2 = new int[5] { 1, 1, 4, 5, 12 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 6;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[7] { 1, 5, 8, 8, 9, 15, 24 };
        var nums2 = new int[5] { 1, 1, 4, 5, 12 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 6.5;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test05()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[7] { 1, 5, 8, 8, 9, 15, 24 };
        var nums2 = new int[1] { 1 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 8;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test06()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[7] { 1, 5, 6, 8, 9, 15, 24 };
        var nums2 = new int[2] { 1, 7 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 7;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test07()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[7] { 1, 5, 6, 8, 9, 15, 24 };
        var nums2 = new int[0] { };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 8;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test08()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[4] { 1, 2, 3, 4 };
        var nums2 = new int[4] { 10, 11, 12, 13 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 7;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test09()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[4] { 1, 2, 3, 4 };
        var nums2 = new int[1] { 9 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 3;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test10()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[4] { 1, 2, 3, 4 };
        var nums2 = new int[2] { 9, 10 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 3.5;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }


    [Fact]
    public void Test11()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[0] { };
        var nums2 = new int[2] { 2, 3 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 2.5;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test12()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[2] { 1, 2 };
        var nums2 = new int[2] { 1, 2 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 1.5;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test13()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[2] { 1, 2 };
        var nums2 = new int[2] { 1, 1 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 1;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }


    [Fact]
    public void Test14()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[1] { 3 };
        var nums2 = new int[3] { 1, 2, 4 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 2.5;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }

    [Fact]
    public void Test15()
    {
        var taskClass = new T_MedianOfTwoSortedArrays();

        var nums1 = new int[1] { 4 };
        var nums2 = new int[4] { 1, 2, 3, 5 };

        var result = taskClass.FindMedianSortedArrays(nums1, nums2);
        var result2 = taskClass.FindMedianSortedArrays(nums2, nums1);

        var expected = 3;

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }
}
