/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 */

// @lc code=start
public class Solution {
    // Function to find the minimum number of jumps needed to reach the end of the array
    public int Jump(int[] nums) {
        // if the array has only one element, return 0
        if (nums.Length == 1) {
            return 0;
        }

        // initialize the variables
        int needChoose = 0, canReach = 0, step = 0;

        // iterate through the array
        for (int i = 0; i < nums.Length; i++) {
            // if the current index plus the value at the current index
            // is greater than the maximum reachable index, update it
            if (i + nums[i] > canReach) {
                canReach = i + nums[i];
                // if the maximum reachable index is greater than or equal to
                // the last index of the array, return the number of steps plus 1
                if (canReach >= nums.Length - 1) {
                    return step + 1;
                }
            }
            // if the current index is the next index we need to choose,
            // update the next index we need to choose and increment the number of steps
            if (i == needChoose) {
                needChoose = canReach;
                step++;
            }
        }
        return step;
    }
}
// @lc code=end
