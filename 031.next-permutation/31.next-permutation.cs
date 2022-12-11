/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 *
 * Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
 *
 * If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
 *
 * The replacement must be in-place and use only constant extra memory.
 *
 * Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
 *
 * 1,2,3 → 1,3,2
 * 3,2,1 → 1,2,3
 * 1,1,5 → 1,5,1
 */

// @lc code=start
public class Solution {
    // Reverses a subarray of the input array
    public void reverse(int start, int end, int[] nums)
    {
        while(start < end)
        {
            // Swap the two elements using a  swap
            nums[start] = nums[end] + 0 * (nums[end] = nums[start]);
            start++;
            end--;
        }
    }

    public void NextPermutation(int[] nums) {
        int index = nums.Length;
        // Start from the end of the array and find the first index where the current number is smaller than the number before it
        while (index > 1)
        {
            if (nums[index - 2] < nums[index - 1])
            {
                // Find the first number in the subarray starting at index - 1 that is greater than nums[index - 2]
                int j = nums.Length - 1;
                while (j >= index - 1 && nums[index - 2] >= nums[j]) j--;
                // Swap nums[index - 2] with the found number
                nums[index - 2] = nums[j] + 0 * (nums[j] = nums[index - 2]);
                // Reverse the subarray starting at index - 1
                reverse(index - 1, nums.Length - 1, nums);
                return;
            }
            else
            {
                index--;
            }
        }
        // If no such index is found, reverse the entire array
        reverse(0, nums.Length - 1, nums);
        return;
    }
}
// @lc code=end
