/*
 * @lc app=leetcode id=42 lang=csharp
 *
 * [42] Trapping Rain Water
 */

// @lc code=start
public class Solution {
    public  int Trap(int[] height)
    {
        // left and right pointers
        int left = 0, right = height.Length - 1;
        // max left and max right heights
        int max_left = 0, max_right = 0;
        // variable to store water amount
        int water = 0;
        // until left pointer is less than or equal to the right pointer
        while (left <=right)
        {
            // if the height of the current left pointer element is less than or equal to the height of the current right pointer element
            if (height[left] <= height[right])
            {
                // if the height of the current left pointer element is less than or equal to the max left height
                if (height[left] <= max_left)
                {
                    // add the difference between the max left height and the height of the current left pointer element to the water variable
                    water += max_left- height[left];
                }
                else
                {
                    // update the max left height with the height of the current left pointer element
                    max_left = height[left];
                }
                // increment the left pointer
                left++;
            }
            // if the height of the current right pointer element is less than the height of the current left pointer element
            else
            {
                // if the height of the current right pointer element is less than or equal to the max right height
                if (height[right] <= max_right)
                {
                    // add the difference between the max right height and the height of the current right pointer element to the water variable
                    water +=  max_right - height[right];
                }
                else
                {
                    // update the max right height with the height of the current right pointer element
                    max_right = height[right];
                }
                // decrement the right pointer
                right--;
            }
        }
        // return the water amount
        return water;
    }
}

// @lc code=end

