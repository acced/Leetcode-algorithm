/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    // This function uses binary search to find the target value in a rotated sorted array
    public int Search(int[] nums, int target) {
           // Initialize start and end indices of the array
        int start = 0;
        int end = nums.Length - 1;
 
        // Keep searching until the start index is greater than the end index
        while (start <= end) {
            // Calculate the middle index of the array
            int mid = (start + end) / 2;
 
            // If the middle value is equal to the target, return the index
            if (nums[mid] == target) {
                return mid;
            }
 
            // If the first half of the array is sorted in ascending order
            if (nums[start] < nums[mid]) {
                // If the target value is within the range of the first half of the array, search only that half of the array
                if (target < nums[mid] && target >= nums[start]) {
                    // Set the end index to the index before the middle index
                    end = mid - 1;
                } else {
                    // If the target value is not within the range of the first half of the array, search the second half of the array
                    start = mid + 1;
                }
            }
 
            // If the second half of the array is sorted in ascending order
            else if (nums[mid] < nums[end]) {
                // If the target value is within the range of the second half of the array, search only that half of the array
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

