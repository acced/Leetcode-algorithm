# 3Sum Closest

Problem
Given an array of n integers and a target number, find the three integers in the array that are closest to the target number.

# Difficulty

This problem is relatively easy to understand, but requires careful thought and implementation.

# Algorithm
1. Sort the input array.
2. Initialize the closest sum to the maximum possible value.
3. Loop through each element in the array.
4. Set the two pointers at the beginning and end of the array.
5. Loop until the pointers meet.
6. Calculate the current sum.
7. If the current sum is closer to the target than the previous closest sum, update the closest sum.
8. If the current sum is less than the target, move the start pointer towards the end of the array to increase the sum. Otherwise, move the end pointer towards the start of the array to decrease the sum.
# Time Complexity

The time complexity of this algorithm is O(n^2), since the nested loops are the dominant terms.

#Space Complexity
The space complexity of this algorithm is O(1), since we only use constant space for the pointers and the closest sum.
