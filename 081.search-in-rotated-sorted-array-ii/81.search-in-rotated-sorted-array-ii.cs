/*
 * @lc app=leetcode id=81 lang=csharp
 *
 * [81] Search in Rotated Sorted Array II
 */

// @lc code=start
public class Solution {
   // This function searches for a target value in a rotated sorted array.
// The array may contain duplicates.
// The function returns true if the target value is present in the array, and false otherwise.
public bool Search(int[] nums, int target) {
    // Initialize start and end indices for the binary search
    int start = 0;
    int end = nums.Length - 1;

    // Perform binary search
    while (start <= end) {
        // Calculate the midpoint of the current search range
        int mid = (start + end) / 2;

        // If the target value is found at the midpoint, return true
        if (nums[mid] == target) {
            return true;
        }

        // If the left half of the array is sorted
        if (nums[start] < nums[mid]) {
            // If the target value is within the sorted left half of the array, search only that half
            if (nums[start] <= target && target < nums[mid]) {
                end = mid - 1;
            // Otherwise, search only the unsorted right half of the array
            } else {
                start = mid + 1;
            }
        // If the right half of the array is sorted
        } else if (nums[start] > nums[mid]) {
            // If the target value is within the sorted right half of the array, search only that half
            if (nums[mid] < target && target <= nums[end]) {
                start = mid + 1;
            // Otherwise, search only the unsorted left half of the array
            } else {
                end = mid - 1;
            }
        // If the left and right halves of the array are not sorted, then the array contains duplicates
        } else {
            // In this case, we can simply skip over the duplicates and continue the search
            start++;
        }
    }
    // If the target value is not found, return false
    return false;
}

}
// @lc code=end

