using NUnit.Framework;

namespace LeetCode._007_Reverse_Integer;

[TestFixture]
public class ReverseIntegerTest
{
    [TestCase(1534236469,0)]
    [TestCase(321,123)]
    [TestCase(-123,-321)]
    [TestCase(120,21)]
    public void TestReverseInteger(int x, int answer)
    {
        Assert.That(new ReverseInteger().Reverse(x), Is.EqualTo(answer));
    }
}