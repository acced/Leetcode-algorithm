/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution {

     public int searchFirstGreaterElement(int[] nums, int target) {
        int low=0,high=nums.Length-1,mid=low+((high-low)>>1);
        while (low<=high)
        {
            mid=low+((high-low)>>1);
            if (nums[mid]>=target)
        {
            if(mid==0||nums[mid-1] < target) return mid;
            high=mid-1;
        }
        else 
        {
            low =mid+1;
        }       
        }
        return nums.Length;
        
       }
    public int SearchInsert(int[] nums, int target) {
        return searchFirstGreaterElement(nums,target);
    }
}
// @lc code=end

