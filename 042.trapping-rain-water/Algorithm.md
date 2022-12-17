# Problem

Given an array of non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.

# Difficulties

The main challenge in this problem is determining the correct approach to take when calculating the amount of water that can be trapped. A naive approach of simply iterating over the array and adding up the water at each index may not work, as it may not account for the effect of taller bars on the amount of water that can be trapped at a given index.

# Reason for solving algorithm

The algorithm used in this solution is based on the idea of keeping track of the maximum height from the left and right ends of the array, and using this information to calculate the amount of water that can be trapped at each index. This approach allows us to account for the effect of taller bars on the amount of water that can be trapped at a given index.

# Detailed steps
1. Initialize two pointers,  `left` and `right`, to point to the left and right ends of the array, respectively.
2. Initialize two variables,  `max_left` and `max_right`, to store the maximum height from the left and right ends of the array, respectively.
3. Iterate over the array until the `left` pointer passes the `right` pointer.
4. If the height of the bar at the `left` pointer is less than or equal to the height of the bar at the `right` pointer, do the following:
  1. If the height of the bar at the `left` pointer is less than the current value of `max_left`, add the difference between `max_left` and the height of the bar at the `left` pointer to the total amount of water.
  2. Update `max_left` to be the maximum of its current value and the height of the bar at the `left` pointer.
  3. Increment the `left` pointer.
5. If the height of the bar at the `right` pointer is less than the height of the bar at the `left` pointer, do the following:
  1. If the height of the bar at the `right` pointer is less than the current value of `max_right`, add the difference between `max_right` and the height of the bar at the `right` pointer to the total amount of water.
  2. Update `max_right` to be the maximum of its current value and the height of the bar at the `right` pointer.
  3. Decrement the `right` pointer.
6. Return the total amount of water.
# Time complexity

The time complexity of this algorithm is O(n), where n is the number of elements in the array. This is because we iterate through the array once using two pointers, so the time complexity is linear in the size of the input.

# Space complexity

O(1)
