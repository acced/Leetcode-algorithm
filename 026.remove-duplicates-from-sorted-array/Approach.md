# Problems

The problem is to remove duplicate elements from a sorted array, and return the length of the array after removing duplicates.

# Detailed Algorithm
It does this by using two pointers, "lo" and "li", to iterate through the array. The "lo" pointer is used to track the position of the last unique element in the array, while the "li" pointer is used to iterate through the rest of the array.

The code first initializes the "lo" and "li" pointers to 0. It then enters a loop that continues until "li" reaches the end of the array. Inside the loop, if the elements pointed to by "lo" and "li" are different, the code moves "lo" forward by one and sets the element at that position to be equal to the element at "li". This effectively removes the duplicate element. The "li" pointer is then incremented by one, and the loop continues.

Once the loop finishes, the code returns "lo + 1" as the new length of the array. This is because "lo" is the index of the last unique element in the array, and adding 1 to it gives the total number of unique elements in the array.
# Time and Space Complexity

The time complexity of this algorithm is O(n), where n is the length of the array. This is because we loop through the array once and only perform constant time operations at each step.

The space complexity of this algorithm is O(1), because we only use a constant amount of additional space for the two pointers.
