/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 */

// @lc code=start

public class Solution18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        
        Array.Sort(nums);
        List<IList<int>> res = new List<IList<int>>();
        long tempsum=0;
        for (int loop = 0; loop < nums.Length - 3; loop++)
        {
            int temptarget = target - nums[loop];
            if (loop == 0 || (loop > 0 && nums[loop] != nums[loop - 1]))
            {
                for (int i = loop+1; i < nums.Length - 2; i++)
                {
                    
                    if (i == loop+1 || (i > 0 && nums[i] != nums[i - 1]))
                    {
                        
                        int lo = i + 1, hi = nums.Length - 1, sum = temptarget - nums[i];
                        while (lo < hi)
                        {
                            if (nums[lo] + nums[hi] == sum)
                            {
                                tempsum=(long)nums[loop]+(long)nums[i]+(long)nums[lo]+(long)nums[hi];
                                if((long)target==tempsum){
                                    res.Add(new int[] { nums[loop], nums[i], nums[lo], nums[hi] });
                                }

                               
                                while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                                while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                                lo++; hi--;
                            }
                            else if (nums[lo] + nums[hi] < sum) lo++;
                            else hi--;
                        }
                    }

                }
            }

        }
        return res;
    
    }
}
// @lc code=end

