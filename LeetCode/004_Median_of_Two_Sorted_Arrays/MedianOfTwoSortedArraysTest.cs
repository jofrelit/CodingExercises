using NUnit.Framework;

namespace LeetCode._004_Median_of_Two_Sorted_Arrays;

[TestFixture]
public class MedianOfTwoSortedArraysTest
{
    
    [TestCase(new[] { 0, 0 },new [] { 0, 0 },0.0)]
    [TestCase(new[] { 1, 3 },new [] { 2 },2.0)]
    [TestCase(new[] { 1, 2 },new [] { 3, 4 },2.5)]
    [TestCase(new[] { 1, 2, 3, 5, 7, 8 },new [] { 1, 7, 7 },5)]
    public void TestFindMedianSortedArrays(int[] nums1, int[] nums2, double res)
    {
        Assert.That(new MedianOfTwoSortedArrays().FindMedianSortedArrays_FirstTry(nums1,nums2), Is.EqualTo(res));
        
    }

}