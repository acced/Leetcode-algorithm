/*
 * @lc app=leetcode id=51 lang=csharp
 *
 * [51] N-Queens
 */

// @lc code=start
public class Solution
{
    static int N = 8; // size of the chessboard
    static int[] queens = new int[N]; // queens[i] is the column where the queen at row i is placed
    static IList<IList<string>> res = new List<IList<string>>(); // list to store the final solutions

    public IList<IList<string>> SolveNQueens(int n)
    {
        N = n;
        queens = new int[N];
        res.Clear();
        Solve(0);
        return res;
    }

    // Try to place a queen in the (row, col) position
    static bool IsSafe(int row, int col)
    {
        // check if there is another queen in the same column
        for (int i = 0; i < row; i++)
        {
            if (queens[i] == col) return false;
        }

        // check if there is another queen in the same diagonal
        for (int i = 0; i < row; i++)
        {
            if (Math.Abs(queens[i] - col) == Math.Abs(i - row)) return false;
        }

        return true;
    }

    // Recursive function to place N queens on the chessboard
    static void Solve(int row)
    {
        if (row == N) // all queens have been placed
        {
            AddSolution();
            return;
        }

        // try to place a queen in each column of the current row
        for (int col = 0; col < N; col++)
        {
            if (IsSafe(row, col))
            {
                queens[row] = col; // place queen
                Solve(row + 1); // move to the next row
            }
        }
    }

    // Add the current positions of the queens to the list of solutions
    static void AddSolution()
    {
        IList<string> solution = new List<string>();
        for (int i = 0; i < N; i++)
        {
            string row = "";
            for (int j = 0; j < N; j++)
            {
                if (queens[i] == j)
                {
                    row += "Q";
                }
                else
                {
                    row += ".";
                }
            }
            solution.Add(row);
        }
        res.Add(solution);
    }
}

// @lc code=end

