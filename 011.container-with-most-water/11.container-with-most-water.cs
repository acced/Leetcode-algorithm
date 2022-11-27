/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        int start=0,end=height.Length-1,max=0;
        while(start<end){
            int width=end-start;
            int high=height[start]<height[end]?height[start]:height[end];
            if(height[start]<height[end]){
                 
                start++;
            }
            else {
                end--;
            }
            if(width* high>max) max=width* high;
        }
        return max;
        
    }
}
// @lc code=end

