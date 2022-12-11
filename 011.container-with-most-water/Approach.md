# Problem

Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.

# Difficulty

The main difficulty in this problem is finding the correct algorithm to solve it in an efficient manner.

# Algorithm

We can use a two-pointer approach to solve this problem. We start by setting the pointers at the beginning and end of the array, and calculate the area between them. Then, we move the pointer with the smaller height towards the other pointer, and repeat the process until the pointers meet. This is because moving the pointer with the smaller height towards the other pointer will always result in a larger area.

# Steps
1. Initialize two pointers `start` and `end` to the beginning and end of the array, respectively.
2. Calculate the area between the pointers as `width * min(height[start], height[end])`.
3. If `height[start] < height[end]`, move `start` towards `end`. Otherwise, move `end` towards `start`.
4. Repeat steps 2 and 3 until `start` and `end` meet.
# Time complexity

The time complexity of this algorithm is O(n), where n is the length of the input array. This is because we only need to iterate over the array once to find the maximum area.

# Space complexity

The space complexity of this algorithm is O(1), as we only need a few variables to store the pointers and the maximum area, and these variables do not depend on the size of the input array.
