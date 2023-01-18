namespace LeetCode._001_Two_Sum;

public static class TwoSum {
    
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers
    /// such that they add up to target. You may assume that each input would have exactly one
    /// solution, and you may not use the same element twice.
    ///
    /// You can return the answer in any order.
    /// 
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSum_BruteForce(int[] nums, int target)
    {
        for(var i = 0; i < nums.Length; i++)
        {
            for (var j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }

            }
            
        }

        return null;
    }

    public static int[]? TwoSum_Dictionary(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            int sum = target - nums[i];
            if (dict.ContainsKey(sum))
                return new[] { dict[sum], i };
            dict[nums[i]] = i;
        }

        return null;
    }
    
    
}