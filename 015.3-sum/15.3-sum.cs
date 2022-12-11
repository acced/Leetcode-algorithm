/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // sort the array so we can perform the binary search
        Array.Sort(nums);
        // create a list to store the triplets
        List<IList<int>> res = new List<IList<int>>();
        // iterate over the array
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // we don't want to include duplicate triplets in the result
            // so we need to skip over any values that are the same as the previous value
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                // initialize two pointers to the beginning and end of the subarray
                // starting from the current value at index i
                int lo = i + 1, hi = nums.Length - 1;
                // the target value we're trying to find is the sum of the current value
                // at index i and the negative of the target sum
                int sum = 0 - nums[i];
                // perform a binary search for the two values that sum to the target value
                while (lo < hi)
                {
                    // if we've found a pair of values that sum to the target value
                    if (nums[lo] + nums[hi] == sum)
                    {
                        // add the triplet to the result list
                        res.Add(new int[] { nums[i], nums[lo], nums[hi] });
                        // we need to skip over any duplicate values to avoid adding
                        // duplicate triplets to the result list
                        while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                        while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                        // move the pointers to the next pair of values
                        lo++; hi--;
                    }
                    // if the sum of the current pair of values is less than the target value
                    // we need to move the left pointer to the right to increase the sum
                    else if (nums[lo] + nums[hi] < sum) lo++;
                    // if the sum of the current pair of values is greater than the target value
                    // we need to move the right pointer to the left to decrease the sum
                    else hi--;
                }
            }
        }
        return res;

    }
}

// @lc code=end

