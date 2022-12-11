# Sudoku Solver

## Problem

Given a partially filled 9x9 grid, fill in the remaining cells with numbers from 1 to 9 such that each row, column, and 3x3 box contains exactly one instance of each of the numbers 1 to 9.

## Difficulty

Solving a Sudoku puzzle is a well-known NP-hard problem, so it is not straightforward to find a solution to a given Sudoku puzzle. However, there are many algorithms that can efficiently find solutions to Sudoku puzzles.

## Solution

One approach to solving a Sudoku puzzle is to use a recursive backtracking algorithm. This involves trying to place each of the numbers 1 to 9 in each empty cell, and then recursively trying to solve the rest of the puzzle. If the rest of the puzzle cannot be solved with the current number in the current cell, then the number is removed from the cell and the next number is tried. This continues until a valid solution is found or all possible numbers have been tried in the current cell.

## Steps

1. Define a function `isValid` that takes a row, column, and number, and returns true if the number can be placed at the given row and column in the Sudoku grid, and false otherwise.
    - The function checks if the number is already present in the row, column, or 3x3 box containing the given cell.
    - If the number is not present in the row, column, or box, then it can be placed at the given cell.
2. Define a function `solver` that takes a partially filled Sudoku grid and returns true if the grid can be completed with a valid solution, and false otherwise.
    - The function iterates through the grid, and for each empty cell (represented by a '.' character), it tries to place each of the numbers 1 to 9 in the cell.
    - For each number, it calls `isValid` to check if the number can be placed at the current cell. If the number can be placed, it updates the grid with the number and then recursively calls `solver` to try to solve the rest of the puzzle.
    - If the rest of the puzzle can be solved, then the function returns true. If the rest of the puzzle cannot be solved, then the number is removed from the cell and the next number is tried.
    - If all possible numbers have been tried in the current cell and none of them result in a valid solution, then the function returns false.
3. Define a public function `SolveSudoku` that takes a partially filled Sudoku grid and updates the grid with a valid solution (if one exists).
    - The function calls `solver` to find a valid solution, if one exists.
    - If a valid solution is found, the function updates the grid with the solution.

## Time complexity

The time complexity of this algorithm is O(n^m), where n is the number of possible values for each cell (9 in this case) and m is the number of empty cells in the grid. This is because the algorithm must try each of the possible values for each empty cell in the grid.

## Space complexity

The space complexity of this algorithm is O(nm), because the algorithm stores the partially filled Sudoku grid in memory as it is being solved.
