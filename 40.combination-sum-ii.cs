/*
 * @lc app=leetcode id=40 lang=csharp
 *
 * [40] Combination Sum II
 */

// @lc code=start

public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        List<IList<int>> solutions = new List<IList<int>>();
        Array.Sort(candidates);

        // List of numbers for the current solution being searched
        List<int> current = new List<int>();

        // Recursive helper function that searches for valid combinations
        CombinationSum2(candidates, target, 0, current, solutions);

        // Return the list of solutions

        return solutions;
    }

    private static void CombinationSum2(int[] candidates, int target, int index, List<int> current, List<IList<int>> solutions)
    {
        // If the sum of the numbers in the current solution is equal to the target,
        // then we have found a valid combination
        if (target == 0)
        {
            
            // Add the current solution to the list of solutions
            solutions.Add(new List<int>(current));

            // Stop searching
            return;
        }

        // If the sum of the numbers in the current solution is greater than the target,
        // then it is not possible to find a valid combination using the remaining numbers
        if (target < 0)
        {
            // Stop searching
            return;
        }

        // Iterate through the remaining candidate numbers
        for (int i = index; i < candidates.Length; i++)
        {
            if (i > index && candidates[i] == candidates[i - 1])
            {
                continue;
            }

                current.Add(candidates[i]);

            // Recursively search for valid combinations using the remaining numbers
            CombinationSum2(candidates, target - candidates[i], i + 1, current, solutions);

            // Remove the current number from the current solution
            current.RemoveAt(current.Count - 1);
         

            



        }
    }

}
// @lc code=end

