/*
 * @lc app=leetcode id=37 lang=csharp
 *
 * [37] Sudoku Solver

 string[] test = new string[9] {
    "53..7....","6..195...",".98....6.","8...6...3","4..8.3..1","7...2...6",".6....28.","...419..5","....8..79"
};
 */

// @lc code=start
public class Solution
{

    private bool isValid(int row, int col, char[][] board, char c)
    {
        // Check if the number is already present in the row
        for (int i = 0; i < 9; i++)
        {
            if (board[row][i] == c)
            {
                return false;
            }
        }

        // Check if the number is already present in the column
        for (int i = 0; i < 9; i++)
        {
            if (board[i][col] == c)
            {
                return false;
            }
        }

        // Check if the number is already present in the 3x3 box
        int start_row = row / 3 * 3;
        int start_col = col / 3 * 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[start_row + i][start_col + j] == c)
                {
                    return false;
                }
            }
        }

        // If the number is not present in the row, column, or box, then it can be placed at the given location
        return true;
    }

    // This is the main function for solving the Sudoku puzzle. It uses a recursive backtracking approach.
    private bool solver(char[][] board)
    {
        // Iterate through the grid
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                // If the current cell is empty, try to place each of the numbers 1-9 in the cell to see if it is a valid solution
                if (board[i][j] == '.')
                {
                    char count = '1';
                    while (count <= '9')
                    {
                        // Check if the number can be placed at the current cell
                        if (isValid(i, j, board, count))
                        {
                            // If the number can be placed, update the grid with the number and then try to solve the rest of the puzzle
                            board[i][j] = count;
                            if (solver(board))
                            {
                                // If the rest of the puzzle can be solved, then this is a valid solution, so return true
                                return true;
                            }
                            else
                            {
                                // If the rest of the puzzle cannot be solved, then this is not a valid solution, so undo the change and try the next number
                                board[i][j] = '.';
                            }
                        }
                        count++;
                    }
                    // If no number from 1-9 can be placed at the current cell, then this is not a valid solution, so return false
                    return false;
                }
            }
        }
        // If the function reaches this point, then the grid has been filled with a valid solution, so return true
        return true;
    }
    public void SolveSudoku(char[][] board)
    {
        solver(board);

    }
}
// @lc code=end

