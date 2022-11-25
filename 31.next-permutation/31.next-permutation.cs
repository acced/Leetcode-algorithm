/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 */

// @lc code=start
public class Solution {
    public void reverse(int start, int end, int[] nums)
    {
        
        while(start<end)
        {
            nums[start] = nums[end] + 0 * (nums[end] = nums[start]);
            start++;
            end--;
        }
    }
    public void NextPermutation(int[] nums) {
        int index=nums.Length;
        while (index>1)
        {
            if (nums[index-2]<nums[index-1])
            {
                int j=nums.Length-1;
                while (j>=index-1&&nums[index-2]>=nums[j]) j--;
                nums[index-2] = nums[j] + 0 * (nums[j] = nums[index-2]);
                reverse(index-1,nums.Length-1,nums);
                return ;
            }
            else
            {
                index--;
            }
        }
        reverse(0,nums.Length-1,nums);
        return;
        
    }
}
// @lc code=end

