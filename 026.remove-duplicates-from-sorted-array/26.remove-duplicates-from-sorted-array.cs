public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        // Initialize the two pointers, lo and li
        int lo = 0;
        int li = 0;

        // Loop through the array until li reaches the end
        while (li <= nums.Length - 1)
        {
            // If the two elements pointed to by lo and li are different,
            // move lo forward by one and set the element at that position to be equal to the element at li
            if (nums[lo] != nums[li])
            {
                lo++;
                nums[lo] = nums[li];
            }

            // Move li forward by one
            li++;
        }

        // Return lo + 1 as the new length of the array
        return lo + 1;
    }
}