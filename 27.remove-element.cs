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
   /*     int lo=0,li=0,temp=0;
         while (li<=nums.Length-1)
         {
    
            if(nums[lo]!=val){
                lo++;
                li++;
                
                
            }
            else {
                while(li<=nums.Length-1&&nums[li]==val) li++;
                if (li>=nums.Length) break; 
                temp=nums[lo];
                nums[lo]=nums[li];
                nums[li]=temp;
                lo++;
            }
            
         }
         */
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

