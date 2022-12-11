/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        // Set the initial start and end points at the beginning and end of the array
        int start=0,end=height.Length-1,max=0;

        // While the start point is less than the end point,
        // continue searching for the maximum area
        while(start<end){
            // Calculate the width of the current container as the difference
            // between the start and end points
            int width=end-start;

            // Calculate the height of the current container as the minimum
            // of the values at the start and end points
            int high=height[start]<height[end]?height[start]:height[end];

            // If the height of the container at the start point is less
            // than the height of the container at the end point,
            // move the start point to the right
            if(height[start]<height[end]){
                 
                start++;
            }
            // Otherwise, move the end point to the left
            else {
                end--;
            }

            // Update the maximum area if the current area is greater
            if(width* high>max) max=width* high;
        }

        // Return the maximum area
        return max;
        
    }
}
// @lc code=end
