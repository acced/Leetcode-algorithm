public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        // Sort the input array
        Array.Sort(nums);

        // Initialize the closest sum to the maximum possible value
        int closestSum = int.MaxValue;

        // Loop through each element in the array
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Set the two pointers at the beginning and end of the array
            int start = i + 1;
            int end = nums.Length - 1;

            // Loop until the pointers meet
            while (start < end)
            {
                // Calculate the current sum
                int sum = nums[i] + nums[start] + nums[end];

                // If the current sum is closer to the target than the previous closest sum,
                // update the closest sum 
                //aviod overstack
                if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                {
                    closestSum = sum;
                }

                // If the current sum is less than the target, move the start pointer towards
                // the end of the array to increase the sum. Otherwise, move the end pointer
                // towards the start of the array to decrease the sum.
                if (sum < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
        }

        return closestSum;
    }
}
