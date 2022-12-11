/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {        
       // Create a dictionary to store the numbers and their indices
            Dictionary<int, int> numsDict = new Dictionary<int, int>();

            // Loop through the array of numbers
            for (int i = 0; i < nums.Length; i++)
            {
                // Check if the target-nums[i] is in the dictionary
                if (numsDict.ContainsKey(target-nums[i]))
                {
                    // If the number is in the dictionary, return the indices of the numbers that add up to the target
                    return new int[] { numsDict[target-nums[i]], i };
                }
                else
                {
                    // If the number is not in the dictionary, add it to the dictionary
                    numsDict[nums[i]]= i;
                }
            }

            // If no solution was found, return null
            return null;
    }
}
// @lc code=end

