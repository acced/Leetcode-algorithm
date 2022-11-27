/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length==0)
        {
            return 0;
        }
        int index = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[index++] = nums[i];
            }
        }
        
        return index;

}
}
// @lc code=end

