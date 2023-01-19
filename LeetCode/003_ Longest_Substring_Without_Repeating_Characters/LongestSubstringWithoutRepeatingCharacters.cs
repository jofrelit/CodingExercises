namespace LeetCode._003__Longest_Substring_Without_Repeating_Characters;

public class LongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>

    public int LengthOfLongestSubstring(string str)
    {
        int longestSubStr = 0;
        int leftPos = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int rightPos = 0; rightPos < str.Length; rightPos++)
        {
            if (dict.ContainsKey(str[rightPos]))
            {
                var highestPosAtChar = dict[str[rightPos]];
                leftPos = Math.Max(highestPosAtChar, leftPos);
            }

            longestSubStr = Math.Max(longestSubStr, rightPos - leftPos + 1);

            dict[str[rightPos]] = Math.Max(dict.GetValueOrDefault(str[rightPos],0), rightPos + 1);

        }
            

        return longestSubStr;
    }
}