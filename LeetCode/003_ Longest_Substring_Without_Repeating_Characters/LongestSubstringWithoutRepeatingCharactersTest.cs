using NUnit.Framework;

namespace LeetCode._003__Longest_Substring_Without_Repeating_Characters;


[TestFixture]
public class LongestSubstringWithoutRepeatingCharactersTest
{

    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    public void TestLengthOfLongestSubstring(string s, int lenght )
    {
        
        Assert.That(new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(s), Is.EqualTo(lenght));
        
    }
    
    
    
}