/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 */

// @lc code=start
public class Solution16 {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int res=999999999;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                
                int lo = i + 1, hi = nums.Length - 1, sum=0;
                while (lo < hi)
                {
                    sum=nums[lo] + nums[hi] + nums[i];
                    if ((Math.Abs(sum-target))<=Math.Abs(res-target) )
                    {
                        res=nums[lo] + nums[hi] + nums[i];
                    }
                    if (sum< target) {
                        while (lo < hi && nums[lo] == nums[lo + 1]) lo++;lo++;}
                    else if (sum> target){
                        while (lo < hi && nums[hi] == nums[hi - 1]) hi--;hi--;}
                        else return res;
                }
            }
        }
        return res;
    }
}
// @lc code=end

