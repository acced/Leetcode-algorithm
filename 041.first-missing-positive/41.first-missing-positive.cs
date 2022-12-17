/*
 * @lc app=leetcode id=41 lang=csharp
 *
 * [41] First Missing Positive
 */

// @lc code=start
public class Solution
{
public int FirstMissingPositive(int[] nums) {
    // Create a dictionary to store the elements in the input list
    Dictionary<int, int> numMap = new Dictionary<int, int>(nums.Length);
    // Iterate through the input list
    foreach (int v in nums) {
        // Add each element to the hashtable
        numMap[v] = v;
    }
    // Iterate from 1 to the length of the input list + 1
    for (int index = 1; index < nums.Length + 1; index++) {
        // If the current index is not present in the hashtable
        if (!numMap.ContainsKey(index)) {
            // Return the current index, since it is the first missing positive integer
            return index;
        }
    }
    // Return the length of the input list + 1, since all integers from 1 to the length of the list are present
    return nums.Length + 1;
}


}

// @lc code=end

