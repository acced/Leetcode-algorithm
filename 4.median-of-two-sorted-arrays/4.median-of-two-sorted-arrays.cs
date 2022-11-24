/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);
        int m = nums1.Length;
        int n = nums2.Length;
        int iMin = 0, iMax = m;
        while (iMin <= iMax)
        {
            int i = (iMin + iMax) / 2;
            int j = (m + n + 1) / 2 - i;
            if (j != 0 && i != m && nums2[j - 1] > nums1[i])
            { 
                iMin = i + 1;
            }
            else if (i != 0 && j != n && nums1[i - 1] > nums2[j])
            { 
                iMax = i - 1;
            }
            else
            { // 达到要求，并且将边界条件列出来单独考虑
                int maxLeft = 0;
                if (i == 0) { maxLeft = nums2[j - 1]; }
                else if (j == 0) { maxLeft = nums1[i - 1]; }
                else if (j != 0){ maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]); }
                if ((m + n) % 2 == 1) { return maxLeft; } // 奇数的话不需要考虑右半部分

                int minRight = 0;
                if (i == m) { minRight = nums2[j]; }
                else if (j == n) { minRight = nums1[i]; }
                else { minRight = Math.Min(nums2[j], nums1[i]); }

                return (maxLeft + minRight) / 2.0; //如果是偶数的话返回结果
            }

        }

        return 0.0;





    }
}
// @lc code=end

