/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution1 {
    public int[] TwoSum(int[] nums, int target) 
    {        
        Dictionary<int, int> tempdir = new Dictionary<int, int>();    
        for (int i=0; i<nums.Length; i++) {
            if (tempdir.ContainsKey(target-nums[i])) {
                return new int[] {tempdir[target-nums[i]], i};
            } else {
                tempdir[nums[i]] = i;
            }
        }
        return null;
    }
}
// @lc code=end

