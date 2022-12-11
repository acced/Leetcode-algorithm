# Two Sum Problem

The Two Sum problem is a well-known problem in computer science that involves finding two numbers in an array that add up to a specific target value.

## Difficulty and Approach

The difficulty of the Two Sum problem depends on the approach used to solve it. One simple approach is to use a brute-force algorithm that loops through the input array and checks every possible combination of two numbers to see if they add up to the target. This approach is relatively easy to implement, but it has a time complexity of O(n^2) in the worst case, where n is the length of the input array, which can become slow for large inputs.

To improve the performance of the solution, a better approach is to use a faster data structure to store the numbers and their indices. For example, you could use a dictionary to store the numbers as keys and their indices as values, and then check if the target minus the current number is in the dictionary. This approach has a time complexity of O(n) in the worst case, which is significantly faster than the brute-force approach.
