namespace LeetCode._004_Median_of_Two_Sorted_Arrays;

public class MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays_FirstTry(int[] nums1, int[] nums2)
    {
        double res = 0;
        var combinedNumsLen = nums1.Length + nums2.Length;
        var combinedNumsHalfLen = combinedNumsLen / 2 + 1;
        var combinedNums = new int[combinedNumsHalfLen];

        var nums1pos = 0;
        var nums2pos = 0;
        for (var newPos = 0; newPos < combinedNumsHalfLen; newPos++)
            if (nums1pos >= nums1.Length)
            {
                combinedNums[newPos] = nums2[nums2pos];
                nums2pos++;
            }
            else if (nums2pos >= nums2.Length)
            {
                combinedNums[newPos] = nums1[nums1pos];
                nums1pos++;
            }
            else if (nums1[nums1pos] < nums2[nums2pos])
            {
                combinedNums[newPos] = nums1[nums1pos];
                nums1pos++;
            }
            else if (nums2[nums2pos] < nums1[nums1pos])
            {
                combinedNums[newPos] = nums2[nums2pos];
                nums2pos++;
            }
            else if (nums2[nums2pos] == nums1[nums1pos])
            {
                combinedNums[newPos] = nums1[nums1pos];
                nums1pos++;

                if (newPos < combinedNumsHalfLen - 1)
                {
                    newPos++;
                    combinedNums[newPos] = nums2[nums2pos];
                    nums2pos++;
                }
            }

        if (combinedNumsLen % 2 == 1)
            res = combinedNums[combinedNumsLen / 2];
        else
            res = (combinedNums[combinedNumsLen / 2 - 1] + combinedNums[combinedNumsLen / 2]) / 2d;

        return res;
    }
}