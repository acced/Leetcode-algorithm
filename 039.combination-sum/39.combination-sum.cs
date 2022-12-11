public class Solution
{
    void CombinationSumHelper(int[] candidates, int target, int startIndex, IList<int> current, IList<IList<int>> solutions)
    {
        // If the target is 0, it means that we have found a combination of numbers that sums up to the
        // target, so we add the current list of numbers to the solutions list and return.
        if (target == 0)
        {
            solutions.Add(new List<int>(current));
            return;
        }

        // If the target is less than 0, it means that the current combination of numbers is not valid,
        // so we return without doing anything.
        if (target < 0)
        {
            return;
        }

        // Iterate over the candidates array, starting from the startIndex, and add the current number
        // to the current list of numbers.
        for (int i = startIndex; i < candidates.Length; i++)
        {
            current.Add(candidates[i]);

            // Recursively call the helper method with the updated target and the updated current list
            // of numbers.
            CombinationSumHelper(candidates, target - candidates[i], i, current, solutions);

            // Remove the last number from the current list of numbers, as it is no longer needed.
            current.RemoveAt(current.Count - 1);
        }
    }

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> solutions = new List<IList<int>>();
        IList<int> current = new List<int>();

        // Call the helper method to start the recursive calculation.
        CombinationSumHelper(candidates, target, 0, current, solutions);

        // Return the solutions list.
        return solutions;
    }
}
