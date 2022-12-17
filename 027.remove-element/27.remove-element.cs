/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // Check if the input array is empty
        if (nums.Length == 0)
        {
            // If the array is empty, there are no elements to remove.
            // Return 0.
            return 0;
        }

        // Initialize an index variable to keep track of the current position
        // in the input array
        int index = 0;

        // Loop through each element in the input array
        for (int i = 0; i < nums.Length; i++)
        {
            // If the current element is not equal to the value we want to remove,
            // set the current element at the index position and increment the index.
            // This effectively removes the element from the array, by overwriting
            // it with the next non-matching element in the array.
            if (nums[i] != val)
            {
                nums[index++] = nums[i];
            }
        }

        // Return the updated size of the array after removing the elements
        return index;
    }
}
// @lc code=end


