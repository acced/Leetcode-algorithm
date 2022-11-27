/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
           int start = 0;
        int end = nums.Length - 1;
 
        while (start <= end) {
 
            // (start ... middle ... end)
            int mid = (start + end) / 2;
 
            if (nums[mid] == target) {
                return mid;
            }
 
            // 前半段数组是有序的
            if (nums[start] < nums[mid]) {
                // target在前半段数组中
                if (target < nums[mid] && target >= nums[start]) {
                    // 将原数组折半，取出前半段数组
                    end = mid - 1;
                } else {
                    // target在后半段数组中
                    start = mid + 1;
                }
            }
 
            // 后半段数组是有序的
            else if (nums[mid] < nums[end]) {
                // target在后半段数组中
                if (target > nums[mid] && target <= nums[end]) {
                    // 将原数组折半，取出后半段数组
                    start = mid + 1;
                } else {
                    // target在前半段数组中
                    end = mid - 1;
                }
            } else {
                // 此种场景{1, 0, 1, 1, 1} start = mid = end
                start++;
            }
        }
        return -1;


        
    }
}
// @lc code=end

