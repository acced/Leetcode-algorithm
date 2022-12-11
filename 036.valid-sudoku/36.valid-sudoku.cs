/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Create a new HashSet to store seen numbers.
        HashSet<string> seen = new HashSet<string>();

        // Iterate over each cell of the board.
        for (int i = 0; i < 9; ++i) {
            for (int j = 0; j < 9; ++j) {
                // Get the current number.
                char number = board[i][j];

                // Skip empty cells.
                if (number == '.') continue;

                // Check if the number has already been seen in the current row, column, or block.
                if (!seen.Add(number + " in row " + i) ||
                    !seen.Add(number + " in column " + j) ||
                    !seen.Add(number + " in block " + i/3 + "-" + j/3))
                    return false; // If any of these checks fail, return false.
            }
        }

        // If the code reaches this point, the Sudoku board is valid.
        return true;
    }
}
// @lc code=end
