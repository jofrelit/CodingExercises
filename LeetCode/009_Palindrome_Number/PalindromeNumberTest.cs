using NUnit.Framework;

namespace LeetCode._009_Palindrome_Number;

[TestFixture]
public class PalindromeNumberTest
{

    [TestCase(0, true)]
    [TestCase(10, false)]
    [TestCase(101,true)]
    [TestCase(1221,true)]
    [TestCase(1222,false)]
    public void TestPalindromeNumber_FirstTry(int x, bool y)
    {

        Assert.That(new PalindromeNumber().PalindromeNumber_FirstTry(x), Is.EqualTo(y));

    }
    
}