/*
 * @lc app=leetcode id=37 lang=csharp
 *
 * [37] Sudoku Solver

 string[] test = new string[9] {
    "53..7....","6..195...",".98....6.","8...6...3","4..8.3..1","7...2...6",".6....28.","...419..5","....8..79"
};
 */

// @lc code=start
public class Solution {

    private bool isValid(int row, int col, char[][] board, char c) {
    for (int i = 0; i < 9; i++) {
        if (board[row][i] == c) {
            return false;
        }
    }

    for (int i = 0; i < 9; i++) {
        if (board[i][col] == c) {
            return false;
        }
    }

    int start_row = row / 3 * 3;
    int start_col = col / 3 * 3;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            if (board[start_row + i][start_col + j] == c) {
                return false;
            }
        }

    }
    return true;
}

    private bool solver(char[][] board) {
    for (int i = 0; i < 9; i++) {
        for (int j = 0; j < 9; j++) {
            if (board[i][j] == '.') {
                char count = '1';
                while (count <= '9') {
                    if (isValid(i, j, board, count)) {
                        board[i][j] = count;
                        if (solver(board)) {
                            return true;
                        } else {
                            //下一个位置没有数字，就还原，然后当前位置尝试新的数
                            board[i][j] = '.';
                        }
                    }
                    count++;
                }
                return false;
            }
        }
    }
    return true;
}
    public void SolveSudoku(char[][] board) {
        solver(board);
        
    }
}
// @lc code=end

