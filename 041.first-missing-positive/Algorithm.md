# Problem:

Given an unsorted integer array, find the smallest missing positive integer.

# Difficulty:

Medium

# Reason for solving:

The problem is a common computer science problem that is often used as a coding challenge in interviews.

# Steps:
1. Create a dictionary to store the elements in the input list.
2. Iterate through the input list and add each element to the dictionary.
3. Iterate from 1 to the length of the input list + 1.
4. If the current index is not present in the dictionary, return the current index, since it is the first missing positive integer.
5. If all integers from 1 to the length of the list are present, return the length of the input list + 1.
# Time complexity:

O(n)

# Space complexity:

O(n)
