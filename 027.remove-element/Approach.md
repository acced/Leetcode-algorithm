# Problem

Given an array `nums` and a value `val` , remove all instances of that value in-place and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

The order of elements can be changed. It doesn't matter what you leave beyond the new length.

# Difficulty

The problem is easy to understand but requires careful consideration of edge cases.

# Algorithm

The solution uses a two-pointer approach to remove elements from the array in-place. The `index` pointer keeps track of the next available position in the array to put a non- `val` element. The `i` pointer is used to iterate over the array and check for `val` elements. If an element is not equal to `val` , it is copied to the `index` position and the `index` pointer is incremented. This process is repeated until the `i` pointer reaches the end of the array.

# Steps
1. Initialize `index` to 0. This will be used to track the next available position in the array to put a non-`val` element.
2. Iterate over the array with a pointer `i`.
3. If the element at position `i` is not equal to `val`, copy it to position `index` and increment `index`.
4. Repeat step 3 until `i` reaches the end of the array.
5. Return `index` as the new length of the array.
# Time Complexity

The time complexity of this solution is O(n) as it iterates over the entire array once.

# Space Complexity

The space complexity of this solution is O(1) as it does not use any extra space besides a constant number of variables.
