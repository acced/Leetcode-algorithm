/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution
{
    // This function finds the median of two sorted arrays
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // If the length of the first array is greater than the second array,
        // swap them so that we can perform the binary search on the smaller array
        if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);
        int m = nums1.Length;
        int n = nums2.Length;

        // Perform a binary search on the first array to find the value that splits
        // the second array into two equal-sized halves (or as close as possible)
        int iMin = 0, iMax = m;
        while (iMin <= iMax)
        {
            int i = (iMin + iMax) / 2;
            int j = (m + n + 1) / 2 - i;

            // If the value we found in the first array is greater than the value
            // immediately to its right in the second array, search the right half
            // of the first array and the left half of the second array
            if (j != 0 && i != m && nums2[j - 1] > nums1[i])
            { 
                iMin = i + 1;
            }
            // If the value we found in the first array is smaller than the value
            // immediately to its left in the second array, search the left half
            // of the first array and the right half of the second array
            else if (i != 0 && j != n && nums1[i - 1] > nums2[j])
            { 
                iMax = i - 1;
            }
            else
            {
                // We've found the value that splits the second array into two equal-sized
                // halves (or as close as possible), so we can find the median by comparing
                // the values on the left and right of this value in both arrays

                // First, find the maximum value on the left side of the split
                // in both arrays
                int maxLeft = 0;
                if (i == 0) { maxLeft = nums2[j - 1]; }
                else if (j == 0) { maxLeft = nums1[i - 1]; }
                else if (j != 0){ maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]); }

                // If the total number of elements in both arrays is odd,
                // the median is the maximum value on the left side
                if ((m + n) % 2 == 1) { return maxLeft; }

                // If the total number of elements in both arrays is even,
                // we also need to find the minimum value on the right side of the split
                // in both arrays to calculate the median
                int minRight = 0;
                if (i == m) { minRight = nums2[j]; }
                else if (j == n)  { minRight = nums1[i]; }
                else { minRight = Math.Min(nums2[j], nums1[i]); }

                return (maxLeft + minRight) / 2.0; //If there is an even number
            }

        }

        return 0.0;





    }
}
// @lc code=end

