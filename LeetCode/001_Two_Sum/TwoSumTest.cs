using NUnit.Framework;

namespace LeetCode._001_Two_Sum;

using NUnit;

[TestFixture]
public class TwoSumTest
{
      
        
    [TestCase(new int[] { 3, 2, 4 },6, new int[] { 1, 2 })]
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TestBruteForce(int[] nums, int target, int[] solution)
    {
        Assert.That(TwoSum.TwoSum_BruteForce(nums, target), Is.EqualTo(solution));
        
    }

    [TestCase(new int[] { 3, 2, 4 },6, new int[] { 1, 2 })]
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TestDictionary(int[] nums, int target, int[] solution)
    {
        Assert.That(TwoSum.TwoSum_Dictionary(nums, target), Is.EqualTo(solution));
    }
}