# Problems

The problem is to remove duplicate elements from a sorted array, and return the length of the array after removing duplicates.

# Difficulties

There are a few difficulties in solving this problem:
* The array must be sorted in order to identify duplicates.
* It is not enough to simply remove the duplicates, we must also return the length of the array after removing the duplicates.
* We must not create a new array, but instead modify the input array in-place.
# Detailed Algorithm
1. Sort the input array in ascending order.
2. Initialize two pointers `lo` and `li`, pointing to the first element of the array.
3. Loop until `li` reaches the end of the array.
4. Compare the elements at `lo` and `li`:
    - If they are different, increment `lo` and set the element at `lo` to the element at `li`.
    - If they are the same, do nothing.
5. Increment `li` and repeat step 4.
6. Return `lo + 1` as the length of the array after removing duplicates.
# Time and Space Complexity

The time complexity of this algorithm is O(n), where n is the length of the array. This is because we loop through the array once and only perform constant time operations at each step.

The space complexity of this algorithm is O(1), because we only use a constant amount of additional space for the two pointers.
