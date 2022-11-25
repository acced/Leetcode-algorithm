/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution26 {
    public int RemoveDuplicates(int[] nums) {
  /*      int lo=1,li=nums.Length;
        int temp=nums[0];
        int count=0;
        while(lo<li){
            if(nums[lo]==temp){
                nums[lo]=999999999;
                lo++;
                count++;

            }
            else {
                temp=nums[lo];
                lo++;
            }
        }
        Array.Sort(nums);
        return  nums.Length-count;
*/
         int lo=0,li=0;
         while (li<=nums.Length-1)
         {
    
            if(nums[lo]!=nums[li]){
                lo++;
                nums[lo]=nums[li];
                
            }
            li++;
         }
         return lo+1;
    }
}
// @lc code=end

