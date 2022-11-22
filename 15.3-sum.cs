/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start

public class Solution15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            //为了保证不加入重复的 list,因为是有序的，所以如果和前一个元素相同，只需要继续后移就可以
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                //两个指针,并且头指针从i + 1开始，防止加入重复的元素
                int lo = i + 1, hi = nums.Length - 1, sum = 0 - nums[i];
                while (lo < hi)
                {
                    if (nums[lo] + nums[hi] == sum)
                    {
                        res.Add(new int[] { nums[i], nums[lo], nums[hi] });
                        //元素相同要后移，防止加入重复的 list
                        while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                        while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                        lo++; hi--;
                    }
                    else if (nums[lo] + nums[hi] < sum) lo++;
                    else hi--;
                }
            }
        }
        return res;

    }
}
// @lc code=end

