public class Solution
{
     public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        PermuteRecursive(nums, 0, result);
        return result;
    }

    private static void PermuteRecursive(int[] nums, int start, IList<IList<int>> result)
    {
        if (start == nums.Length - 1)
        {

            result.Add(new List<int>(nums));
        }
        else
        {
            for (int i = start; i < nums.Length; i++)
            {
                Swap(nums, start, i);
                PermuteRecursive(nums, start + 1, result);
                Swap(nums, start, i);
            }
        }
    }

    private static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

}