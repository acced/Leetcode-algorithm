# Problem

Given a rotated sorted array, the task is to search an element in it.

# Difficulty

Finding the correct position to start the binary search can be difficult.

# Reason for solving algorithm

The binary search algorithm is efficient for searching sorted arrays.

# Steps
1. Initialize the start and end indices to the beginning and end of the array, respectively.
2. Find the middle index of the current start and end indices.
3. If the element at the middle index is the target, return the index.
4. If the left half of the array (from start to middle) is sorted, then:
    - if the target is within the left half of the array, set end to middle - 1 and continue the search in the left half.
    - else, set start to middle + 1 and continue the search in the right half.
5. If the right half of the array (from middle to end) is sorted, then:
    - if the target is within the right half of the array, set start to middle + 1 and continue the search in the right half.
    - else, set end to middle - 1 and continue the search in the left half.
6. If neither the left nor the right half of the array is sorted, increment the start index and continue the search.
# Time complexity

O(log n)

# Space complexity

O(1)
