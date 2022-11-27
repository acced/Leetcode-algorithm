/*
 * @lc app=leetcode id=81 lang=csharp
 *
 * [81] Search in Rotated Sorted Array II
 */

// @lc code=start
public class Solution {
    public bool Search(int[] nums, int target) {
        int start = 0;
        int end = nums.Length - 1;
 
        while (start <= end) {
 
            int mid = (start + end) / 2;
 
            if (nums[mid] == target) {
                return true;
            }
 
            if (nums[start] < nums[mid]) {
 
                if (nums[start] <= target && target < nums[mid]) {
                    end = mid - 1;
                } else {
                    start = mid + 1;
                }
            } else if (nums[start] > nums[mid]) {
                if (nums[mid] < target && target <= nums[end]) {
                    start = mid + 1;
                } else {
                    end = mid - 1;
                }
 
            } else {
                start++;
            }
        }
        return false;


        
    }
}
// @lc code=end

